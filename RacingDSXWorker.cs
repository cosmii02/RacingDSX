using RacingDSX.Config;
using RacingDSX.GameParsers;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

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

		RacingDSX.Config.Config settings;
		IProgress<RacingDSXReportStruct> progressReporter;
		Parser parser;





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

		//This sends the data to DSX based on the input parsed data from Forza.
		//See DataPacket.cs for more details about what forza parameters can be accessed.
		//See the Enums at the bottom of this file for details about commands that can be sent to DualSenseX
		//Also see the Test Function below to see examples about those commands
		void SendData()
		{
			Packet p = new Packet();
	//		Parser parser = new ForzaParser(settings);
			CsvData csvRecord = new CsvData();
			Profile activeProfile = settings.ActiveProfile;
			ReportableInstruction reportableInstruction = new ReportableInstruction();
		

			// No race = normal triggers
			if (!parser.IsRaceOn())
			{
			

				reportableInstruction = parser.GetPreRaceInstructions();
				p.instructions = reportableInstruction.Instructions;
				reportableInstruction.RacingDSXReportStructs.ForEach(x =>
				{

					if (x.verboseLevel <= settings.VerboseLevel
											&& progressReporter != null)
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

                if (x.verboseLevel <= settings.VerboseLevel
				                                        && progressReporter != null)
				{
                    progressReporter.Report(x);
                }
            });
			Packet p = new Packet();
			p.instructions = reportableInstruction.Instructions;
            //Send the commands to DSX
            Send(p);
        }

		//Maps floats from one range to another.
	

		//private DataPacket data;
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

			int portNum;

			if (!int.TryParse(portNumber.ToString(), out portNum))
			{
				// handle parse failure
			}
			{
				if (progressReporter != null)
				{
					progressReporter.Report(new RacingDSXReportStruct($"DSX provided a non-numerical port! Using configured default ({settings.DSXPort})."));
				}
				portNum = settings.DSXPort;
			}

			endPoint = new IPEndPoint(Triggers.localhost, portNum);

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
			if (settings.VerboseLevel > VerboseLevel.Limited
				&& progressReporter != null)
			{
				progressReporter.Report(new RacingDSXReportStruct($"Converting Message to JSON" ));
			}
			byte[] RequestData = Encoding.ASCII.GetBytes(Triggers.PacketToJson(data));
			if (settings.VerboseLevel > VerboseLevel.Limited
				&& progressReporter != null)
			{
				progressReporter.Report(new RacingDSXReportStruct($"{Encoding.ASCII.GetString(RequestData)}" ));
			}
			try
			{
				if (settings.VerboseLevel > VerboseLevel.Limited
					&& progressReporter != null)
				{
					progressReporter.Report(new RacingDSXReportStruct($"Sending Message to DSX..." ));
				}

				senderClient.Send(RequestData, RequestData.Length);

				if (settings.VerboseLevel > VerboseLevel.Limited
					&& progressReporter != null)
				{
					progressReporter.Report(new RacingDSXReportStruct($"Message sent to DSX" ));
				}
			}
			catch (Exception e)
			{
				if (progressReporter != null)
					progressReporter.Report(new RacingDSXReportStruct("Error Sending Message: " ));

				if (e is SocketException)
				{
					if (progressReporter != null)
						progressReporter.Report(new RacingDSXReportStruct("Couldn't Access Port. " + e.Message ));
					throw e;
				}
				else if (e is ObjectDisposedException)
				{
					if (progressReporter != null)
						progressReporter.Report(new RacingDSXReportStruct("Connection closed. Restarting..."));
					Connect();
				}
				else
				{
					if (progressReporter != null)
						progressReporter.Report(new RacingDSXReportStruct("Unknown Error: " + e.Message));
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
				//parser = new ForzaParser(settings);
				//Connect to Forza
				ipEndPoint = new IPEndPoint(IPAddress.Loopback, settings.ActiveProfile.gameUDPPort);
				client = new UdpClient(settings.ActiveProfile.gameUDPPort);

				DataPacket data;
				byte[] resultBuffer;
				//UdpReceiveResult receive;

				//Main loop, go until killed
				while (bRunning)
				{
					//If Forza sends an update
					resultBuffer = client.Receive(ref ipEndPoint);
					if (resultBuffer == null)
						continue;
					//receive = await client.ReceiveAsync();
					if (settings.VerboseLevel > VerboseLevel.Limited
						&& progressReporter != null)
					{
						progressReporter.Report(new RacingDSXReportStruct("recieved Message from Forza!"));
					}
					//parse data
					//var resultBuffer = receive.Buffer;
					if (!AdjustToBufferType(resultBuffer.Length))
					{
						//  return;
					}
					//data = parseDirtData(resultBuffer);
					parser.ParsePacket(resultBuffer);
					if (settings.VerboseLevel > VerboseLevel.Limited
						&& progressReporter != null)
					{
						progressReporter.Report(new RacingDSXReportStruct("Data Parsed"));
					}

					//Process and send data to DSX
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

			if (settings.VerboseLevel > VerboseLevel.Off
					&& progressReporter != null)
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




        //Parses data from Forza into a DataPacket
     /*   DataPacket ParseData(byte[] packet)
		{
			DataPacket data = new DataPacket();

			// sled
			data.IsRaceOn = packet.IsRaceOn();
			data.TimestampMS = packet.TimestampMs();
			data.EngineMaxRpm = packet.EngineMaxRpm();
			data.EngineIdleRpm = packet.EngineIdleRpm();
			data.CurrentEngineRpm = packet.CurrentEngineRpm();
			data.AccelerationX = packet.AccelerationX();
			data.AccelerationY = packet.AccelerationY();
			data.AccelerationZ = packet.AccelerationZ();
			data.VelocityX = packet.VelocityX();
			data.VelocityY = packet.VelocityY();
			data.VelocityZ = packet.VelocityZ();
			data.AngularVelocityX = packet.AngularVelocityX();
			data.AngularVelocityY = packet.AngularVelocityY();
			data.AngularVelocityZ = packet.AngularVelocityZ();
			data.Yaw = packet.Yaw();
			data.Pitch = packet.Pitch();
			data.Roll = packet.Roll();
			data.NormalizedSuspensionTravelFrontLeft = packet.NormSuspensionTravelFl();
			data.NormalizedSuspensionTravelFrontRight = packet.NormSuspensionTravelFr();
			data.NormalizedSuspensionTravelRearLeft = packet.NormSuspensionTravelRl();
			data.NormalizedSuspensionTravelRearRight = packet.NormSuspensionTravelRr();
			data.TireSlipRatioFrontLeft = packet.TireSlipRatioFl();
			data.TireSlipRatioFrontRight = packet.TireSlipRatioFr();
			data.TireSlipRatioRearLeft = packet.TireSlipRatioRl();
			data.TireSlipRatioRearRight = packet.TireSlipRatioRr();
			data.WheelRotationSpeedFrontLeft = packet.WheelRotationSpeedFl();
			data.WheelRotationSpeedFrontRight = packet.WheelRotationSpeedFr();
			data.WheelRotationSpeedRearLeft = packet.WheelRotationSpeedRl();
			data.WheelRotationSpeedRearRight = packet.WheelRotationSpeedRr();
			data.WheelOnRumbleStripFrontLeft = packet.WheelOnRumbleStripFl();
			data.WheelOnRumbleStripFrontRight = packet.WheelOnRumbleStripFr();
			data.WheelOnRumbleStripRearLeft = packet.WheelOnRumbleStripRl();
			data.WheelOnRumbleStripRearRight = packet.WheelOnRumbleStripRr();
			data.WheelInPuddleDepthFrontLeft = packet.WheelInPuddleFl();
			data.WheelInPuddleDepthFrontRight = packet.WheelInPuddleFr();
			data.WheelInPuddleDepthRearLeft = packet.WheelInPuddleRl();
			data.WheelInPuddleDepthRearRight = packet.WheelInPuddleRr();
			data.SurfaceRumbleFrontLeft = packet.SurfaceRumbleFl();
			data.SurfaceRumbleFrontRight = packet.SurfaceRumbleFr();
			data.SurfaceRumbleRearLeft = packet.SurfaceRumbleRl();
			data.SurfaceRumbleRearRight = packet.SurfaceRumbleRr();
			data.TireSlipAngleFrontLeft = packet.TireSlipAngleFl();
			data.TireSlipAngleFrontRight = packet.TireSlipAngleFr();
			data.TireSlipAngleRearLeft = packet.TireSlipAngleRl();
			data.TireSlipAngleRearRight = packet.TireSlipAngleRr();
			data.TireCombinedSlipFrontLeft = packet.TireCombinedSlipFl();
			data.TireCombinedSlipFrontRight = packet.TireCombinedSlipFr();
			data.TireCombinedSlipRearLeft = packet.TireCombinedSlipRl();
			data.TireCombinedSlipRearRight = packet.TireCombinedSlipRr();
			data.SuspensionTravelMetersFrontLeft = packet.SuspensionTravelMetersFl();
			data.SuspensionTravelMetersFrontRight = packet.SuspensionTravelMetersFr();
			data.SuspensionTravelMetersRearLeft = packet.SuspensionTravelMetersRl();
			data.SuspensionTravelMetersRearRight = packet.SuspensionTravelMetersRr();
			data.CarOrdinal = packet.CarOrdinal();
			data.CarClass = packet.CarClass();
			data.CarPerformanceIndex = packet.CarPerformanceIndex();
			data.DrivetrainType = packet.DriveTrain();
			data.NumCylinders = packet.NumCylinders();

			// dash
			data.PositionX = packet.PositionX();
			data.PositionY = packet.PositionY();
			data.PositionZ = packet.PositionZ();
			data.Speed = packet.Speed();
			data.Power = packet.Power();
			data.Torque = packet.Torque();
			data.TireTempFl = packet.TireTempFl();
			data.TireTempFr = packet.TireTempFr();
			data.TireTempRl = packet.TireTempRl();
			data.TireTempRr = packet.TireTempRr();
			data.Boost = packet.Boost();
			data.Fuel = packet.Fuel();
			data.Distance = packet.Distance();
			data.BestLapTime = packet.BestLapTime();
			data.LastLapTime = packet.LastLapTime();
			data.CurrentLapTime = packet.CurrentLapTime();
			data.CurrentRaceTime = packet.CurrentRaceTime();
			data.Lap = packet.Lap();
			data.RacePosition = packet.RacePosition();
			data.Accelerator = packet.Accelerator();
			data.Brake = packet.Brake();
			data.Clutch = packet.Clutch();
			data.Handbrake = packet.Handbrake();
			data.Gear = packet.Gear();
			data.Steer = packet.Steer();
			data.NormalDrivingLine = packet.NormalDrivingLine();
			data.NormalAiBrakeDifference = packet.NormalAiBrakeDifference();

			return data;
		}*/

		//Support different standards
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
