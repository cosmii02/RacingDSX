using RacingDSX.Config;
using RacingDSX.GameParsers;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace RacingDSX
{
    public enum InstructionTriggerMode : sbyte
    {
        NONE,
        RESISTANCE,
        VIBRATION
    }

    public class RacingDSXWorker
    {
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
                // 0 = Throttle vibration message
                THROTTLE_VIBRATION = 0,
                // 1 = Throttle message
                THROTTLE,
                // 2 = Brake vibration message
                BRAKE_VIBRATION,
                // 3 = Brake message
                BRAKE
            }
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
                this.message = String.Empty;
            }

            public RacingDSXReportStruct(string msg)
            {
                this.type = ReportType.VERBOSEMESSAGE;
                this.message = String.Empty;
            }

            public ReportType type = 0;
            public RacingReportType racingType = 0;
            public string message = string.Empty;
            public VerboseLevel verboseLevel = VerboseLevel.Limited;
        }

        private RacingDSX.Config.Config settings;
        private IProgress<RacingDSXReportStruct> progressReporter;
        private Parser parser;

        // JSON serialization options
        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public RacingDSXWorker(RacingDSX.Config.Config currentSettings, IProgress<RacingDSXReportStruct> progressReporter)
        {
            settings = currentSettings;
            this.progressReporter = progressReporter;
        }

        public void SetSettings(RacingDSX.Config.Config currentSettings)
        {
            lock(this)
            {
                settings = currentSettings;
            }
        }

        void SendData()
        {
            Packet p = new Packet();
            CsvData csvRecord = new CsvData();
            Profile activeProfile = settings.ActiveProfile;
            ReportableInstruction reportableInstruction = new ReportableInstruction();
        
            // No race = normal triggers
            if (!parser.IsRaceOn())
            {
                reportableInstruction = parser.GetPreRaceInstructions();
                p.Instructions = reportableInstruction.Instructions;
                reportableInstruction.RacingDSXReportStructs.ForEach(x =>
                {
                    if (x.verboseLevel <= settings.VerboseLevel && progressReporter != null)
                    {
                        progressReporter.Report(x);
                    }
                });

                //Send the commands to DSX
                Send(p);
            }
            else
            {
                reportableInstruction = parser.GetInRaceRightTriggerInstruction();
                sendReportableInstruction(reportableInstruction);
                reportableInstruction = parser.GetInRaceLeftTriggerInstruction();
                sendReportableInstruction(reportableInstruction);
                reportableInstruction = parser.GetInRaceLightbarInstruction();
                sendReportableInstruction(reportableInstruction);
            }
        }

        private void sendReportableInstruction(ReportableInstruction reportableInstruction)
        {
            reportableInstruction.RacingDSXReportStructs.ForEach(x =>
            {
                if (x.verboseLevel <= settings.VerboseLevel && progressReporter != null)
                {
                    progressReporter.Report(x);
                }
            });
            Packet p = new Packet();
            p.Instructions = reportableInstruction.Instructions;
            //Send the commands to DSX
            Send(p);
        }

        static UdpClient senderClient;
        static IPEndPoint endPoint;

        // Connect to DSX
        void Connect()
        {
            senderClient = new UdpClient();
            var portNumber = settings.DSXPort;

            if (progressReporter != null)
            {
                progressReporter.Report(new RacingDSXReportStruct("DSX is using port " + portNumber + ". Attempting to connect.."));
            }

            if (!int.TryParse(portNumber.ToString(), out int portNum))
            {
                if (progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct($"DSX provided a non-numerical port! Using configured default ({settings.DSXPort})."));
                }
                portNum = settings.DSXPort;
            }

            endPoint = new IPEndPoint(IPAddress.Loopback, portNum);

            try
            {
                senderClient.Connect(endPoint);
            }
            catch (Exception e)
            {
                if (progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct("Error connecting: " + e.Message));

                    if (e is SocketException)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Couldn't access port. " + e.Message));
                    }
                    else if (e is ObjectDisposedException)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Connection object closed. Restart the application."));
                    }
                    else
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Unknown error: " + e.Message));
                    }
                }
            }
        }

        //Send Data to DSX
        void Send(Packet data)
        {
            if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
            {
                progressReporter.Report(new RacingDSXReportStruct($"Converting Message to JSON"));
            }

            try
            {
                string jsonString = JsonSerializer.Serialize(data, jsonOptions);
                byte[] RequestData = Encoding.ASCII.GetBytes(jsonString);

                if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct($"{Encoding.ASCII.GetString(RequestData)}"));
                }

                if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct($"Sending Message to DSX..."));
                }

                senderClient.Send(RequestData, RequestData.Length);

                if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct($"Message sent to DSX"));
                }
            }
            catch (JsonException je)
            {
                if (progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct($"JSON Serialization Error: {je.Message}"));
                }
            }
            catch (Exception e)
            {
                if (progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct("Error Sending Message: "));
                }

                if (e is SocketException)
                {
                    if (progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Couldn't Access Port. " + e.Message));
                    }
                    throw;
                }
                else if (e is ObjectDisposedException)
                {
                    if (progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Connection closed. Restarting..."));
                    }
                    Connect();
                }
                else
                {
                    if (progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Unknown Error: " + e.Message));
                    }
                }
            }
        }

        static IPEndPoint ipEndPoint = null;
        static UdpClient client = null;
        
        public struct UdpState
        {
            public UdpClient u;
            public IPEndPoint e;

            public UdpState(UdpClient u, IPEndPoint e)
            {
                this.u = u;
                this.e = e;
            }
        }

        protected bool bRunning = false;

        public void Run()
        {
            bRunning = true;
            try
            {
                Connect();
                if (settings.ActiveProfile == null)
                {
                    if (progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("No active profile selected. Exiting..."));
                    }
                    return;
                }

                switch (settings.ActiveProfile.GameType)
                {
                    case GameTypes.Forza:
                        parser = new ForzaParser(settings);
                        break;
                    case GameTypes.Dirt:
                        parser = new DirtParser(settings);
                        break;
                    default:
                        parser = new NullParser(settings);
                        break;
                }

                ipEndPoint = new IPEndPoint(IPAddress.Loopback, settings.ActiveProfile.gameUDPPort);
                client = new UdpClient(settings.ActiveProfile.gameUDPPort);

                byte[] resultBuffer;

                while (bRunning)
                {
                    resultBuffer = client.Receive(ref ipEndPoint);
                    if (resultBuffer == null)
                        continue;

                    if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("received Message from Forza!"));
                    }

                    if (!AdjustToBufferType(resultBuffer.Length))
                    {
                        continue;
                    }

                    parser.ParsePacket(resultBuffer);
                    if (settings.VerboseLevel > VerboseLevel.Limited && progressReporter != null)
                    {
                        progressReporter.Report(new RacingDSXReportStruct("Data Parsed"));
                    }

                    SendData();
                }
            }
            catch (Exception e)
            {
                if (progressReporter != null)
                {
                    progressReporter.Report(new RacingDSXReportStruct("Application encountered an exception: " + e.Message));
                }
            }
            finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            bRunning = false;

            if (settings.VerboseLevel > VerboseLevel.Off && progressReporter != null)
            {
                progressReporter.Report(new RacingDSXReportStruct($"Cleaning Up"));
            }

            if (client != null)
            {
                client.Close();
                client.Dispose();
            }
            if (senderClient != null)
            {
                senderClient.Close();
                senderClient.Dispose();
            }

            if (settings.VerboseLevel > VerboseLevel.Off)
            {
                progressReporter.Report(new RacingDSXReportStruct($"Cleanup Finished. Exiting..."));
            }
        }

        static bool AdjustToBufferType(int bufferLength)
        {
            switch (bufferLength)
            {
                case 232: // FM7 sled
                    return false;
                case 311: // FM7 dash
                    FMData.BufferOffset = 0;
                    return true;
                case 331: // FM8 dash
                    FMData.BufferOffset = 0;
                    return true;
                case 324: // FH4
                    FMData.BufferOffset = 12;
                    return true;
                default:
                    return false;
            }
        }
    }
}