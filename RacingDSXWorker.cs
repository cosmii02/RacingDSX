using RacingDSX.Config;
using RacingDSX.GameParsers;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading; // Added for CancellationToken

namespace RacingDSX
{
    // Enum definition remains the same
    public enum InstructionTriggerMode : sbyte
    {
        NONE,
        RESISTANCE,
        VIBRATION
    }

    // RacingDSXReportStruct definition remains largely the same
    // (Consider simplifying constructors if some are unused, but kept for compatibility)
    public struct RacingDSXReportStruct
    {
        public enum ReportType : ushort
        {
            VERBOSEMESSAGE = 0,
            NORACE = 1,
            RACING = 2
        }

        public enum RacingReportType : ushort
        {
            THROTTLE_VIBRATION = 0,
            THROTTLE,
            BRAKE_VIBRATION,
            BRAKE
        }
        // Constructors remain the same
        public RacingDSXReportStruct(VerboseLevel level, ReportType type, RacingReportType racingType, string msg)
        {
            this.verboseLevel = level;
            this.type = type;
            this.racingType = racingType;
            this.message = msg;
        }

        public RacingDSXReportStruct(ReportType type, RacingReportType racingType, string msg)
        {
            this.type = type;
            this.racingType = racingType;
            this.message = msg;
        }

        public RacingDSXReportStruct(VerboseLevel level, ReportType type, string msg)
        {
            this.verboseLevel = level;
            this.type = type;
            this.message = msg;
        }

        public RacingDSXReportStruct(ReportType type, string msg)
        {
            this.type = type;
            this.message = msg;
        }

        public RacingDSXReportStruct(VerboseLevel level, string msg)
        {
            this.verboseLevel = level;
            this.type = ReportType.VERBOSEMESSAGE;
            // Corrected: Assign the message
            this.message = msg;
            // Corrected: Default racingType if needed or remove if VERBOSEMESSAGE doesn't use it
            this.racingType = 0;
        }

        public RacingDSXReportStruct(string msg)
        {
            this.type = ReportType.VERBOSEMESSAGE;
             // Corrected: Assign the message
            this.message = msg;
            // Corrected: Default verboseLevel and racingType if needed
            this.verboseLevel = VerboseLevel.Limited;
            this.racingType = 0;
        }


        public ReportType type; // Keep public fields if required by external components
        public RacingReportType racingType;
        public string message;
        public VerboseLevel verboseLevel; // Default should be set appropriately if needed
    }

    // Implement IDisposable for proper resource cleanup
    public class RacingDSXWorker : IDisposable
    {
        // --- Constants for Buffer Sizes ---
        private const int FM7_SLED_BUFFER_SIZE = 232;
        private const int DIRT_RALLY_1_BUFFER_SIZE = 264; // Example name, adjust if needed
        private const int FM7_DASH_BUFFER_SIZE = 311;
        private const int FM8_DASH_BUFFER_SIZE = 331;
        private const int FH4_BUFFER_SIZE = 324;
        private const int FH4_BUFFER_OFFSET = 12;
        private const int DEFAULT_BUFFER_OFFSET = 0;

        // --- Member Variables ---
        private RacingDSX.Config.Config settings;
        private readonly IProgress<RacingDSXReportStruct> progressReporter; // Make readonly if set only in constructor
        private Parser parser;
        private UdpClient senderClient = null; // Initialize to null
        private UdpClient listenerClient = null; // Renamed from 'client' for clarity
        private IPEndPoint senderEndPoint = null; // Renamed from 'endPoint'
        private IPEndPoint listenerEndPoint = null; // Renamed from 'ipEndPoint'
        private volatile bool isRunning = false; // Use volatile for thread safety signal
        private readonly object settingsLock = new object(); // Dedicated lock object
        private readonly object sendLock = new object(); // Lock for Send operations if senderClient is shared/reconnected

        // Reuse Packet object to reduce allocations
        private readonly Packet reusablePacket = new Packet();

        // JSON serialization options (already static readonly - good)
        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        // --- Constructor ---
        public RacingDSXWorker(RacingDSX.Config.Config currentSettings, IProgress<RacingDSXReportStruct> progressReporter)
        {
            // Use null-coalescing operator for safety, though settings should ideally not be null
            settings = currentSettings ?? throw new ArgumentNullException(nameof(currentSettings));
            this.progressReporter = progressReporter; // Can be null
        }

        // --- Public Methods ---
        public void SetSettings(RacingDSX.Config.Config currentSettings)
        {
            lock (settingsLock) // Use the dedicated lock object
            {
                settings = currentSettings ?? throw new ArgumentNullException(nameof(currentSettings));
                // If parser depends on settings, it might need to be updated or recreated here
                // parser?.UpdateSettings(settings); // Example if parser needs updates
            }
        }

        public void Run()
        {
            if (isRunning)
            {
                Report(VerboseLevel.Minimal, "Worker is already running.");
                return;
            }
            isRunning = true;
            Report(VerboseLevel.Minimal, "Worker starting...");

            try
            {
                // 1. Connect to DSX Sender Port
                if (!ConnectSender())
                {
                    Report(VerboseLevel.Minimal, "Failed to connect to DSX. Exiting worker.");
                    isRunning = false; // Ensure state reflects reality
                    return; // Exit if connection failed
                }

                // 2. Get Settings and Initialize Parser
                Profile activeProfile;
                lock(settingsLock)
                {
                     activeProfile = settings.ActiveProfile;
                }

                if (activeProfile == null)
                {
                    Report(VerboseLevel.Minimal, "No active profile selected. Exiting...");
                    isRunning = false;
                    return;
                }

                Report(VerboseLevel.Limited, $"Using profile: {activeProfile.ProfileName}, Game: {activeProfile.GameType}, Port: {activeProfile.gameUDPPort}");

                // Create parser based on profile AFTER sender is connected and profile confirmed
                parser = CreateParser(activeProfile);
                if (parser is NullParser)
                {
                     Report(VerboseLevel.Minimal, "Unsupported game type or NullParser configured. Exiting...");
                     isRunning = false;
                     return;
                }

                // 3. Setup Game Listener Port
                if (!InitializeListener(activeProfile.gameUDPPort))
                {
                    Report(VerboseLevel.Minimal, "Failed to initialize game listener. Exiting worker.");
                    isRunning = false;
                    return; // Exit if listener setup failed
                }

                Report(VerboseLevel.Limited, $"Listening for game data on port {activeProfile.gameUDPPort}");

                // 4. Main Loop
                byte[] receiveBuffer;
                while (isRunning)
                {
                    try
                    {
                        // Receive blocks until data arrives or socket is closed
                        receiveBuffer = listenerClient.Receive(ref listenerEndPoint); // Use listenerEndPoint

                        if (!isRunning) break; // Check flag after blocking call

                        if (receiveBuffer == null || receiveBuffer.Length == 0)
                            continue;

                        Report(VerboseLevel.Diagnostic, $"Received {receiveBuffer.Length} bytes from game."); // Changed level

                        // Adjust buffer offset based on packet size (specific to Forza?)
                        if (!AdjustBufferSettings(receiveBuffer.Length))
                        {
                            Report(VerboseLevel.Debug, $"Ignoring packet with unhandled size: {receiveBuffer.Length}");
                            continue;
                        }

                        // Parse the data
                        parser.ParsePacket(receiveBuffer);
                        Report(VerboseLevel.Diagnostic, "Game data parsed."); // Changed level

                        // Process and Send Data
                        ProcessAndSendData();

                    }
                    // Catch specific exceptions from Receive or inner logic
                    catch (SocketException se) when (se.SocketErrorCode == SocketError.Interrupted || se.SocketErrorCode == SocketError.OperationAborted)
                    {
                        // Expected when Stop() closes the listenerClient
                        Report(VerboseLevel.Debug, "Listener socket closed, likely due to Stop() call.");
                        isRunning = false; // Ensure loop terminates
                    }
                    catch (SocketException se)
                    {
                        Report(VerboseLevel.Minimal, $"Socket Error during receive/process: {se.Message} (Code: {se.SocketErrorCode}). Stopping worker.");
                        isRunning = false; // Stop on critical socket errors
                    }
                    catch (ObjectDisposedException ode)
                    {
                         Report(VerboseLevel.Minimal, $"Listener client disposed unexpectedly: {ode.Message}. Stopping worker.");
                         isRunning = false; // Stop if client is disposed
                    }
                    catch (Exception ex)
                    {
                        // Catch other potential errors during parsing or sending
                        Report(VerboseLevel.Minimal, $"Error in worker loop: {ex.Message}");
                        // Decide if the error is fatal or recoverable
                        // For now, continue loop unless it's a known fatal issue
                        // isRunning = false; // Optional: Stop on any error
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch setup errors (ConnectSender, InitializeListener, CreateParser)
                Report(VerboseLevel.Minimal, $"Worker setup failed or unhandled exception: {ex.Message}");
            }
            finally
            {
                Report(VerboseLevel.Minimal, "Worker loop finished or terminated.");
                Cleanup(); // Ensure cleanup happens
                isRunning = false; // Explicitly set state
            }
        }


        public void Stop()
        {
            Report(VerboseLevel.Minimal, "Stop requested.");
            isRunning = false; // Signal the loop to stop

            // Close the listener client immediately to unblock the Receive call
            // Do this safely in case it's already null or disposed
            try
            {
                listenerClient?.Close();
            }
            catch (ObjectDisposedException) { /* Ignore if already disposed */ }
            catch (Exception ex)
            {
                Report(VerboseLevel.Minimal, $"Error closing listener client during Stop: {ex.Message}");
            }

            // Cleanup will handle the sender client and disposal
        }

        // Implement IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent finalizer from running
        }

        // Protected virtual Dispose method
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources only if called from Dispose()
                Stop(); // Ensure worker loop is signalled to stop
                Cleanup(); // Perform the actual cleanup
            }
            // No unmanaged resources to free directly in this class
        }

        // --- Private Helper Methods ---

        // Combined processing and sending logic
        private void ProcessAndSendData()
        {
            if (parser == null) return; // Safety check

            Profile currentProfile;
             lock(settingsLock)
             {
                 currentProfile = settings.ActiveProfile;
             }
             // If profile became null somehow after start, handle appropriately
             if (currentProfile == null) return;

            ReportableInstruction instructionToSend;

            if (!parser.IsRaceOn())
            {
                instructionToSend = parser.GetPreRaceInstructions();
                ReportAndSendInstruction(instructionToSend, RacingDSXReportStruct.ReportType.NORACE);
            }
            else
            {
                // Send Right Trigger (Throttle)
                instructionToSend = parser.GetInRaceRightTriggerInstruction();
                ReportAndSendInstruction(instructionToSend, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.THROTTLE); // Assuming this type

                // Send Left Trigger (Brake)
                instructionToSend = parser.GetInRaceLeftTriggerInstruction();
                ReportAndSendInstruction(instructionToSend, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.BRAKE); // Assuming this type

                // Send Lightbar
                instructionToSend = parser.GetInRaceLightbarInstruction();
                ReportAndSendInstruction(instructionToSend, RacingDSXReportStruct.ReportType.RACING); // No specific racing subtype for lightbar?
            }
        }

        // Consolidated method to report and send instructions
        private void ReportAndSendInstruction(ReportableInstruction reportableInstruction, RacingDSXReportStruct.ReportType reportType, RacingDSXReportStruct.RacingReportType racingType = 0) // Default racingType if not always applicable
        {
            if (reportableInstruction == null || reportableInstruction.Instructions == null)
            {
                Report(VerboseLevel.Debug, "Received null or empty instruction set. Skipping send.");
                return;
            }

            // Report messages associated with the instruction generation
             if (progressReporter != null) // Check reporter once
             {
                VerboseLevel currentVerboseLevel;
                lock(settingsLock) { currentVerboseLevel = settings.VerboseLevel; }

                reportableInstruction.RacingDSXReportStructs?.ForEach(report => // Use ?. for safety
                {
                    // Assign consistent types if missing from original report struct
                    if(report.type == 0) report.type = reportType; // Assuming 0 means VERBOSEMESSAGE or unset
                    if(report.racingType == 0 && reportType == RacingDSXReportStruct.ReportType.RACING) report.racingType = racingType;

                    if (report.verboseLevel <= currentVerboseLevel)
                    {
                        progressReporter.Report(report);
                    }
                });
             }


            // Prepare and send the packet
            lock (reusablePacket) // Lock if reusing packet across potential threads (though Run is likely single-threaded)
            {
                reusablePacket.Instructions = reportableInstruction.Instructions;
                SendPacket(reusablePacket);
            }
        }


        // Connects the UDP client used for sending data to DSX
        private bool ConnectSender()
        {
            lock (sendLock) // Protect senderClient access
            {
                // Clean up existing client if any before reconnecting
                senderClient?.Close();
                senderClient?.Dispose();
                senderClient = null;

                int portNum;
                try
                {
                    lock (settingsLock)
                    {
                        portNum = settings.DSXPort;
                    }
                    senderEndPoint = new IPEndPoint(IPAddress.Loopback, portNum); // Use Loopback consistently
                    senderClient = new UdpClient();
                    senderClient.Connect(senderEndPoint); // Connect establishes default remote host

                    Report(VerboseLevel.Limited, $"DSX sender connected to {senderEndPoint}.");
                    return true;
                }
                catch (Exception e)
                {
                    Report(VerboseLevel.Minimal, $"Error connecting DSX sender to port {settings?.DSXPort ?? 0}: {e.Message}");
                    // Optional: More specific error reporting like before
                    if (e is SocketException se)
                    {
                        Report(VerboseLevel.Minimal, $"Socket Error Code: {se.SocketErrorCode}");
                    }
                    senderClient?.Dispose(); // Ensure cleanup on failure
                    senderClient = null;
                    senderEndPoint = null;
                    return false;
                }
            }
        }

        // Initializes the UDP client for listening to game data
        private bool InitializeListener(int port)
        {
            try
            {
                // Clean up existing listener if necessary (e.g., changing profile)
                listenerClient?.Close();
                listenerClient?.Dispose();

                listenerEndPoint = new IPEndPoint(IPAddress.Any, port); // Listen on any interface for the specified port
                listenerClient = new UdpClient(listenerEndPoint); // Bind to the endpoint

                 Report(VerboseLevel.Limited, $"Game listener initialized on {listenerEndPoint}.");
                return true;
            }
            catch (SocketException se)
            {
                Report(VerboseLevel.Minimal, $"Error initializing game listener on port {port}: {se.Message} (Code: {se.SocketErrorCode})");
                Report(VerboseLevel.Minimal, "Check if another application is using this port or if firewall rules are blocking it.");
                listenerClient?.Dispose();
                listenerClient = null;
                listenerEndPoint = null;
                return false;
            }
             catch (Exception e)
            {
                Report(VerboseLevel.Minimal, $"Unexpected error initializing game listener: {e.Message}");
                listenerClient?.Dispose();
                listenerClient = null;
                listenerEndPoint = null;
                return false;
            }
        }

         // Creates the appropriate parser based on GameType
        private Parser CreateParser(Profile activeProfile)
        {
             Report(VerboseLevel.Debug, $"Creating parser for game type: {activeProfile.GameType}");
             // Pass settings safely
             RacingDSX.Config.Config currentSettings;
             lock(settingsLock)
             {
                 // Pass a copy or ensure settings are thread-safe if parser modifies them
                 // Assuming parser only reads settings for now.
                 currentSettings = settings;
             }

             switch (activeProfile.GameType)
            {
                case GameTypes.Forza:
                    return new ForzaParser(currentSettings);
                case GameTypes.Dirt:
                    return new DirtParser(currentSettings);
                // Add cases for other game types
                default:
                    Report(VerboseLevel.Minimal, $"No specific parser found for game type {activeProfile.GameType}. Using NullParser.");
                    return new NullParser(currentSettings);
            }
        }


        // Sends the Packet data to the connected DSX endpoint
        private void SendPacket(Packet data)
        {
            lock (sendLock) // Protect access to senderClient, especially if reconnect logic exists
            {
                if (senderClient == null || !senderClient.Client.Connected) // Check connection state
                {
                    Report(VerboseLevel.Limited, "DSX sender not connected. Attempting to reconnect...");
                    if (!ConnectSender()) // Attempt to reconnect
                    {
                        Report(VerboseLevel.Minimal, "DSX reconnection failed. Cannot send packet.");
                        return; // Skip sending if reconnect fails
                    }
                    // If ConnectSender succeeded, senderClient should now be connected
                    Report(VerboseLevel.Limited,"DSX reconnected successfully.");
                }

                VerboseLevel currentVerboseLevel;
                 lock(settingsLock) { currentVerboseLevel = settings.VerboseLevel; }


                try
                {
                    if (currentVerboseLevel >= VerboseLevel.Diagnostic) // Use >= for levels
                    {
                        Report(VerboseLevel.Diagnostic, "Converting packet to JSON...");
                    }

                    string jsonString = JsonSerializer.Serialize(data, jsonOptions);
                    byte[] requestData = Encoding.ASCII.GetBytes(jsonString); // Use camelCase for local var

                    if (currentVerboseLevel >= VerboseLevel.Diagnostic)
                    {
                        // Limit logged string length if it can be very long
                        const int maxLogLength = 200;
                        string dataToLog = jsonString.Length > maxLogLength ? jsonString.Substring(0, maxLogLength) + "..." : jsonString;
                        Report(VerboseLevel.Diagnostic, $"Sending JSON: {dataToLog}");
                    }

                    int bytesSent = senderClient.Send(requestData, requestData.Length); // Send using connected client

                    if (currentVerboseLevel >= VerboseLevel.Diagnostic)
                    {
                        Report(VerboseLevel.Diagnostic, $"Sent {bytesSent} bytes to DSX.");
                    }
                }
                catch (JsonException je)
                {
                    Report(VerboseLevel.Minimal, $"JSON Serialization Error: {je.Message}");
                }
                catch (SocketException se)
                {
                    // Connection might have been lost since the check
                    Report(VerboseLevel.Minimal, $"Socket Error Sending Message: {se.Message} (Code: {se.SocketErrorCode})");
                    // Consider attempting reconnect again or marking sender as disconnected
                    senderClient?.Close(); // Close potentially broken connection
                    senderClient = null; // Mark as disconnected
                    senderEndPoint = null;
                }
                 catch (ObjectDisposedException ode)
                 {
                    Report(VerboseLevel.Minimal, $"Sender client disposed unexpectedly during Send: {ode.Message}.");
                    // Attempt to reconnect immediately or on next call
                    senderClient = null; // Mark as disconnected
                    senderEndPoint = null;
                 }
                catch (Exception e)
                {
                    Report(VerboseLevel.Minimal, $"Unknown Error Sending Message: {e.Message}");
                     // Consider cleanup or state change based on the error
                }
            } // end lock(sendLock)
        }

        // Cleans up network resources
        private void Cleanup()
        {
            Report(VerboseLevel.Minimal, "Cleaning up resources...");

             lock (sendLock) // Ensure sender isn't used while cleaning up
             {
                 try
                 {
                     senderClient?.Close();
                     senderClient?.Dispose();
                     senderClient = null;
                     senderEndPoint = null;
                      Report(VerboseLevel.Debug, "Sender client closed and disposed.");
                 }
                 catch(Exception ex) { Report(VerboseLevel.Minimal,$"Error disposing sender client: {ex.Message}"); }

             }

             // No lock needed for listenerClient here as Stop() should have closed it
             // and Run() loop should have exited. Just Dispose.
            try
            {
                listenerClient?.Dispose();
                listenerClient = null;
                listenerEndPoint = null;
                 Report(VerboseLevel.Debug, "Listener client disposed.");
            }
            catch(Exception ex) { Report(VerboseLevel.Minimal,$"Error disposing listener client: {ex.Message}"); }


            Report(VerboseLevel.Limited, "Cleanup finished.");
        }

        // Helper for consistent reporting
        private void Report(VerboseLevel level, string message)
        {
            if (progressReporter != null) // Check if reporter exists
            {
                 VerboseLevel currentVerboseLevel;
                 // Safely get current verbose level setting
                 lock(settingsLock) { currentVerboseLevel = settings.VerboseLevel; }

                // Check if the message level is sufficient for reporting
                if (level <= currentVerboseLevel)
                {
                    // Create a simple verbose message report struct
                    progressReporter.Report(new RacingDSXReportStruct(level, RacingDSXReportStruct.ReportType.VERBOSEMESSAGE, message));
                }
            }
             // Optional: Log to console or debug output as a fallback if progressReporter is null
             // else { System.Diagnostics.Debug.WriteLine($"[{level}] {message}"); }
        }


        // Adjusts buffer settings based on length (e.g., Forza offsets)
        static bool AdjustBufferSettings(int bufferLength)
        {
            // Default offset
            FMData.BufferOffset = DEFAULT_BUFFER_OFFSET; // Assuming FMData is accessible and static modification is intended design

            switch (bufferLength)
            {
                case FM7_SLED_BUFFER_SIZE: // FM7 sled
                    // Assuming this format is not processed further based on original code
                    return false; // Indicate not to process this packet type

                case DIRT_RALLY_1_BUFFER_SIZE: // Dirt Rally 1 (Example)
                    // No offset change needed
                    return true; // Process this packet

                case FM7_DASH_BUFFER_SIZE: // FM7 dash
                    // No offset change needed
                    return true; // Process this packet

                 case FM8_DASH_BUFFER_SIZE: // FM8 dash
                    // No offset change needed
                    return true; // Process this packet

                case FH4_BUFFER_SIZE: // FH4
                    FMData.BufferOffset = FH4_BUFFER_OFFSET; // Set specific offset
                    return true; // Process this packet

                default:
                    // Unknown or unhandled packet size
                    return false; // Indicate not to process
            }
        }

        // Removed UdpState struct as it was unused.
        // Removed static fields for clients/endpoints; managed instance fields now.
    }

     // Assume these classes exist elsewhere
    public static class FMData { public static int BufferOffset { get; set; } }
    public class Packet { public /*List<Instruction> or similar*/ object Instructions { get; set; } } // Placeholder type
    public class ReportableInstruction { public /*List<Instruction>*/ object Instructions { get; set; } public System.Collections.Generic.List<RacingDSXReportStruct> RacingDSXReportStructs { get; set; } = new System.Collections.Generic.List<RacingDSXReportStruct>(); } // Placeholder type
    public class CsvData { /* Placeholder */ } // Unused in provided snippet but kept if needed elsewhere
    // NullParser, ForzaParser, DirtParser assumed to implement IGameParser or similar
    public interface Parser {
        bool IsRaceOn();
        ReportableInstruction GetPreRaceInstructions();
        ReportableInstruction GetInRaceRightTriggerInstruction();
        ReportableInstruction GetInRaceLeftTriggerInstruction();
        ReportableInstruction GetInRaceLightbarInstruction();
        void ParsePacket(byte[] data);
        // void UpdateSettings(Config.Config settings); // Optional: If parser needs live updates
        }
    public class NullParser : Parser {
        public NullParser(Config.Config s) { }
        public bool IsRaceOn() => false;
        public ReportableInstruction GetPreRaceInstructions() => new ReportableInstruction();
        public ReportableInstruction GetInRaceRightTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLeftTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLightbarInstruction()=> new ReportableInstruction();
        public void ParsePacket(byte[] data) { }
    }
     public class ForzaParser : Parser { // Placeholder implementation
        public ForzaParser(Config.Config s) { }
         public bool IsRaceOn() => true; // Example
        public ReportableInstruction GetPreRaceInstructions() => new ReportableInstruction();
        public ReportableInstruction GetInRaceRightTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLeftTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLightbarInstruction()=> new ReportableInstruction();
        public void ParsePacket(byte[] data) { }
     }
     public class DirtParser : Parser { // Placeholder implementation
        public DirtParser(Config.Config s) { }
         public bool IsRaceOn() => true; // Example
        public ReportableInstruction GetPreRaceInstructions() => new ReportableInstruction();
        public ReportableInstruction GetInRaceRightTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLeftTriggerInstruction()=> new ReportableInstruction();
        public ReportableInstruction GetInRaceLightbarInstruction()=> new ReportableInstruction();
        public void ParsePacket(byte[] data) { }
     }

}

// Assume Config namespace exists with required classes/enums
namespace RacingDSX.Config
{
    public class Config { public int DSXPort { get; set; } = 11500; public Profile ActiveProfile { get; set; } public VerboseLevel VerboseLevel { get; set; } = VerboseLevel.Limited; }
    public class Profile { public string ProfileName {get;set;} = "Default"; public GameTypes GameType { get; set; } = GameTypes.Forza; public int gameUDPPort { get; set; } = 5300; }
    public enum GameTypes { Forza, Dirt /*, other games */ }
    public enum VerboseLevel : sbyte { Off = -1, Minimal = 0, Limited = 1, Debug = 2, Diagnostic = 3 } // Example levels
}
