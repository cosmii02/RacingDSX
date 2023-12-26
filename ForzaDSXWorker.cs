using ForzaDSX.Config;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ForzaDSX
{
	public enum InstructionTriggerMode : sbyte
	{
		NONE,
		RESISTANCE,
		VIBRATION
	}

	public class ForzaDSXWorker
	{
		public struct ForzaDSXReportStruct
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

			public ForzaDSXReportStruct(ReportType type, RacingReportType racingType, string msg)
			{
				this.type = type;
				this.racingType = racingType;
				this.message = msg;
			}

			public ForzaDSXReportStruct(ReportType type, string msg)
			{
				this.type = type;
				this.message = msg;
			}

			public ForzaDSXReportStruct(string msg)
			{
				this.type = ReportType.VERBOSEMESSAGE;
				this.message = String.Empty;
			}

			public ReportType type = 0;
			public RacingReportType racingType = 0;
			public string message = string.Empty;
		}

		ForzaDSX.Config.Config settings;
		IProgress<ForzaDSXReportStruct> progressReporter;

		int lastThrottleResistance = 1;
		int lastThrottleFreq = 0;
		int lastBrakeResistance = 200;
		int lastBrakeFreq = 0;

		uint LastValidCarClass = 0;
		int LastValidCarCPI = 0;
		float MaxCPI = 255;

		float LastEngineRPM = 0;
		// FH does not always correctly set IsRaceOn, so we must also check if the RPM info is the same for a certain ammount of time
		uint LastRPMAccumulator = 0;
		uint RPMAccumulatorTriggerRaceOff = 200;

		// Colors for Light Bar while in menus -> using car's PI colors from Forza
		public static readonly uint CarClassD = 0;
		public static readonly int[] ColorClassD = { 107, 185, 236 };
		public static readonly uint CarClassC = 1;
		public static readonly int[] ColorClassC = { 234, 202, 49 };
		public static readonly uint CarClassB = 2;
		public static readonly int[] ColorClassB = { 211, 90, 37 };
		public static readonly uint CarClassA = 3;
		public static readonly int[] ColorClassA = { 187, 59, 34 };
		public static readonly uint CarClassS1 = 4;
		public static readonly int[] ColorClassS1 = { 128, 54, 243 };
		public static readonly uint CarClassS2 = 5;
		public static readonly int[] ColorClassS2 = { 75, 88, 229 };
		public static readonly int[] ColorClassX = { 105, 182, 72 };


		public ForzaDSXWorker(ForzaDSX.Config.Config currentSettings, IProgress<ForzaDSXReportStruct> progressReporter)
		{
			settings = currentSettings;
			this.progressReporter = progressReporter;
		}

		public void SetSettings(ForzaDSX.Config.Config currentSettings)
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
		void SendData(DataPacket data)
		{
			Packet p = new Packet();
			CsvData csvRecord = new CsvData();
			Profile activeProfile = settings.ActiveProfile;
			//Set the controller to do this for
			int controllerIndex = 0;

			////Initialize our array of instructions
			//p.instructions = new Instruction[3];

			/* Combined variables */
			int resistance = 0;
			int filteredResistance = 0;
			float avgAccel = 0;
			int freq = 0;
			int filteredFreq = 0;

			bool bInRace = data.IsRaceOn;

			float currentRPM = data.CurrentEngineRpm;
			// FH does not always correctly set IsRaceOn, so we must also check if the RPM info is the same for a certain ammount of time
			// Also check if Power <= 0 (car is really stopped)
			if (currentRPM == LastEngineRPM
				&& data.Power <= 0)
			{
				LastRPMAccumulator++;
				if (LastRPMAccumulator > RPMAccumulatorTriggerRaceOff)
				{
					bInRace = false;
				}
			}
			else
			{
				LastRPMAccumulator = 0;
			}

			LastEngineRPM = currentRPM;

			//Get average tire slippage. This value runs from 0.0 upwards with a value of 1.0 or greater meaning total loss of grip.
			float combinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight) + Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 4;
			float combinedFrontTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight)) / 2;
			float combinedRearTireSlip = (Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 2;

			uint currentClass = LastValidCarClass;
			if (data.CarClass > 0)
			{
				LastValidCarClass = currentClass = data.CarClass;
			}

			int currentCPI = LastValidCarCPI;
			if (data.CarPerformanceIndex > 0)
			{
				LastValidCarCPI = currentCPI = Math.Min((int)data.CarPerformanceIndex, 255);
			}

			// Right Trigger (index 2)
			//int RightTrigger = 2;
			Instruction RightTrigger = new Instruction();
			RightTrigger.type = InstructionType.TriggerUpdate;
			//p.instructions[RightTrigger].type = InstructionType.TriggerUpdate;

			// Left Trigger
			//int LeftTrigger = 1;
			//p.instructions[LeftTrigger].type = InstructionType.TriggerUpdate;
			Instruction LeftTrigger = new Instruction();
			LeftTrigger.type = InstructionType.TriggerUpdate;

			// Light Bar
			//int LightBar = 0;
			//p.instructions[LightBar].type = InstructionType.RGBUpdate;
			Instruction LightBar = new Instruction();
			LightBar.type = InstructionType.RGBUpdate;

			// No race = normal triggers
			if (!bInRace)
			{
				RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
				LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };

				#region Light Bar color
				int CPIcolorR = 255;
				int CPIcolorG = 255;
				int CPIcolorB = 255;

				float cpiRatio = currentCPI / MaxCPI;

				if (currentClass <= CarClassD)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassD[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassD[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassD[2]);
				}
				else if (currentClass <= CarClassC)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassC[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassC[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassC[2]);
				}
				else if (currentClass <= CarClassB)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassB[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassB[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassB[2]);
				}
				else if (currentClass <= CarClassA)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassA[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassA[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassA[2]);
				}
				else if (currentClass <= CarClassS1)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassS1[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassS1[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassS1[2]);
				}
				else if (currentClass <= CarClassS2)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassS2[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassS2[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassS2[2]);
				}
				else
				{
					CPIcolorR = ColorClassX[0];
					CPIcolorG = ColorClassX[1];
					CPIcolorB = ColorClassX[2];
				}

				LightBar.parameters = new object[] { controllerIndex, CPIcolorR, CPIcolorG, CPIcolorB };
				#endregion

				if (settings.VerboseLevel > 0
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.NORACE, $"No race going on. Normal Triggers. Car's Class = {currentClass}; CPI = {currentCPI}; CPI Ratio = {cpiRatio}; Color [{CPIcolorR}, {CPIcolorG}, {CPIcolorB}]" ));
				}

				p.instructions = new Instruction[] { LightBar, LeftTrigger, RightTrigger };

				//Send the commands to DSX
				Send(p);
			}
			else
			{
				#region Right Trigger
				//Set the updates for the right Trigger(Throttle)
				ThrottleSettings throttleSettings = activeProfile.throttleSettings;
				avgAccel = (float)Math.Sqrt((throttleSettings.TurnAccelerationScale * (data.AccelerationX * data.AccelerationX)) + (throttleSettings.ForwardAccelerationScale * (data.AccelerationZ * data.AccelerationZ)));

				// Define losing grip as front tires slipping or rear tires slipping while accelerating a fair ammount
				bool bLosingAccelGrip =
					combinedFrontTireSlip > throttleSettings.GripLossValue
				|| (combinedRearTireSlip > throttleSettings.GripLossValue && data.Accelerator > 200);

				if (throttleSettings.TriggerMode == Config.TriggerMode.Off)
				{
					RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
				}
				// If losing grip, start to "vibrate"
				else if (bLosingAccelGrip && throttleSettings.TriggerMode == Config.TriggerMode.Vibration)
				{
					freq = (int)Math.Floor(Map(combinedTireSlip, throttleSettings.GripLossValue, 5, 0, throttleSettings.MaxVibration));
					resistance = (int)Math.Floor(Map(avgAccel, 0, throttleSettings.AccelerationLimit, throttleSettings.MinStiffness, throttleSettings.MaxStiffness));
					filteredResistance = (int)EWMA(resistance, lastThrottleResistance, throttleSettings.ResistanceSmoothing);
					filteredFreq = (int)EWMA(freq, lastThrottleFreq, throttleSettings.VibrationSmoothing);

					lastThrottleResistance = filteredResistance;
					lastThrottleFreq = filteredFreq;

					if (filteredFreq <=  throttleSettings.MinVibration
                        || data.Accelerator <= throttleSettings.VibrationModeStart)
					{
						RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Resistance, 0, filteredResistance * throttleSettings.EffectIntensity };

						filteredFreq = 0;
						filteredResistance = 0;
					}
					else
					{
						RightTrigger.parameters = new object[] { 
							controllerIndex, Trigger.Right, TriggerMode.CustomTriggerValue, CustomTriggerValueMode.VibrateResistance, 
							filteredFreq * throttleSettings.EffectIntensity, filteredResistance * throttleSettings.EffectIntensity,throttleSettings.VibrationModeStart, 0, 0, 0, 0 };
					}

					if (settings.VerboseLevel > 0
						&& progressReporter != null)
					{
						progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.THROTTLE_VIBRATION, $"Setting Throttle to vibration mode with freq: {filteredFreq}\r\n Resistance: {filteredResistance}" ));
					}
				}
				else
				{
					//It should probably always be uniformly stiff
					resistance = (int)Math.Floor(Map(avgAccel, 0, throttleSettings.AccelerationLimit, throttleSettings.MinResistance, throttleSettings.MaxResistance));
					filteredResistance = (int)EWMA(resistance, lastThrottleResistance, throttleSettings.ResistanceSmoothing);

					lastThrottleResistance = filteredResistance;
					RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Resistance, 0, filteredResistance * throttleSettings.EffectIntensity };

					if (settings.VerboseLevel > 0
						&& progressReporter != null)
					{
						progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.THROTTLE_VIBRATION, String.Empty));
					}
				}

				if (settings.VerboseLevel > 0
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.THROTTLE, $"Average Acceleration: {avgAccel}\r\n Throttle Resistance: {filteredResistance}\r\n Accelerator: {data.Accelerator}" ));
				}

				p.instructions = new Instruction[] { RightTrigger };

				//Send the commands to DSX
				Send(p);
				#endregion
				#region Left Trigger
				//Update the left(Brake) trigger
				BrakeSettings brakeSettings = activeProfile.brakeSettings;
				// Define losing grip as tires slipping while braking a fair ammount
				bool bLosingBrakeGrip = combinedTireSlip > brakeSettings.GripLossValue && data.Brake > 100;

				if (brakeSettings.TriggerMode == Config.TriggerMode.Off)
				{
					LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };
				}
				// If losing grip, start to "vibrate"
				else if (bLosingBrakeGrip && brakeSettings.TriggerMode == Config.TriggerMode.Vibration)
				{
					freq = (int)Math.Floor(Map(combinedTireSlip, brakeSettings.GripLossValue, 5, 0, brakeSettings.MaxVibration));
					resistance = (int)Math.Floor(Map(data.Brake, 0, 255, brakeSettings.MaxStiffness , brakeSettings.MinStiffness));
					filteredResistance = (int)EWMA(resistance, lastBrakeResistance, brakeSettings.ResistanceSmoothing);
					filteredFreq = (int)EWMA(freq, lastBrakeFreq, brakeSettings.VibrationSmoothing);

					lastBrakeResistance = filteredResistance;
					lastBrakeFreq = filteredFreq;

					if (filteredFreq <= brakeSettings.MinVibration)
					{
						LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Resistance, 0, 0 };
					}
					else
					{
						LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.CustomTriggerValue, CustomTriggerValueMode.VibrateResistance, 
							filteredFreq *brakeSettings.EffectIntensity, filteredResistance * brakeSettings.EffectIntensity, brakeSettings.VibrationStart, 0, 0, 0, 0 };
					}
					//Set left trigger to the custom mode VibrateResitance with values of Frequency = freq, Stiffness = 104, startPostion = 76. 
					if (settings.VerboseLevel > 0
						&& progressReporter != null)
					{
						progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.BRAKE_VIBRATION, $"Setting Brake to vibration mode with freq: {filteredFreq}\r\n Resistance: {filteredResistance}" ));
					}
				}
				else
				{
					//By default, Increasingly resistant to force
					resistance = (int)Math.Floor(Map(data.Brake, 0, 255, brakeSettings.MinResistance, brakeSettings.MaxResistance));
					filteredResistance = (int)EWMA(resistance, lastBrakeResistance, brakeSettings.ResistanceSmoothing);
					lastBrakeResistance = filteredResistance;

					LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Resistance, 0, filteredResistance * brakeSettings.EffectIntensity };

					if (settings.VerboseLevel > 0
						&& progressReporter != null)
					{
						progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.BRAKE_VIBRATION, String.Empty ));
					}
				}

				if (settings.VerboseLevel > 0
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct(ForzaDSXReportStruct.ReportType.RACING, ForzaDSXReportStruct.RacingReportType.BRAKE, $"Brake: {data.Brake}\r\n Brake Resistance: {filteredResistance}\r\n Tire Slip: {combinedTireSlip} \r\n FLCPS: {data.frontLeftContactPatchV} \r\n speed: {data.Speed}" ));
				}

				p.instructions = new Instruction[] { LeftTrigger};

				//Send the commands to DSX
				Send(p);
				#endregion

				#region Light Bar
				//Update the light bar
				//Currently registers intensity on the green channel based on engine RPM as a percantage of the maxium. Changes to red if RPM ratio > 80% (usually red line)
				float engineRange = data.EngineMaxRpm - data.EngineIdleRpm;
				float CurrentRPMRatio = (currentRPM - data.EngineIdleRpm) / engineRange;
				int GreenChannel = Math.Max((int)Math.Floor(CurrentRPMRatio * 255), 50);
				int RedChannel = (int)Math.Floor(CurrentRPMRatio * 255);
				if (CurrentRPMRatio >= activeProfile.RPMRedlineRatio)
				{
					// Remove Green
					GreenChannel = 255 - GreenChannel;
				}

				LightBar.parameters = new object[] { controllerIndex, RedChannel, GreenChannel, 0 };

				if (settings.VerboseLevel > VerboseLevel.Limited
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct($"Engine RPM: {data.CurrentEngineRpm}; Engine Max RPM: {data.EngineMaxRpm}; Engine Idle RPM: {data.EngineIdleRpm}"));
				}

				p.instructions = new Instruction[] { LightBar };

				//Send the commands to DSX
				Send(p);
				#endregion
			}
		}

		//Maps floats from one range to another.
		public float Map(float x, float in_min, float in_max, float out_min, float out_max)
		{
			if (x > in_max)
			{
				x = in_max;
			}
			else if (x < in_min)
			{
				x = in_min;
			}
			return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
		}

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
				progressReporter.Report(new ForzaDSXReportStruct("DSX is using port " + portNumber + ". Attempting to connect.."));
			}

			int portNum;

			if (!int.TryParse(portNumber.ToString(), out portNum))
			{
				// handle parse failure
			}
			{
				if (progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct($"DSX provided a non-numerical port! Using configured default ({settings.DSXPort})."));
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
					progressReporter.Report(new ForzaDSXReportStruct("Error connecting: " + e.Message));

					if (e is SocketException)
					{
						progressReporter.Report(new ForzaDSXReportStruct("Couldn't access port. " + e.Message));
					}
					else if (e is ObjectDisposedException)
					{
						progressReporter.Report(new ForzaDSXReportStruct("Connection object closed. Restart the application."));
					}
					else
					{
						progressReporter.Report(new ForzaDSXReportStruct("Unknown error: " + e.Message));
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
				progressReporter.Report(new ForzaDSXReportStruct($"Converting Message to JSON" ));
			}
			byte[] RequestData = Encoding.ASCII.GetBytes(Triggers.PacketToJson(data));
			if (settings.VerboseLevel > VerboseLevel.Limited
				&& progressReporter != null)
			{
				progressReporter.Report(new ForzaDSXReportStruct($"{Encoding.ASCII.GetString(RequestData)}" ));
			}
			try
			{
				if (settings.VerboseLevel > VerboseLevel.Limited
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct($"Sending Message to DSX..." ));
				}

				senderClient.Send(RequestData, RequestData.Length);

				if (settings.VerboseLevel > VerboseLevel.Limited
					&& progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct($"Message sent to DSX" ));
				}
			}
			catch (Exception e)
			{
				if (progressReporter != null)
					progressReporter.Report(new ForzaDSXReportStruct("Error Sending Message: " ));

				if (e is SocketException)
				{
					if (progressReporter != null)
						progressReporter.Report(new ForzaDSXReportStruct("Couldn't Access Port. " + e.Message ));
					throw e;
				}
				else if (e is ObjectDisposedException)
				{
					if (progressReporter != null)
						progressReporter.Report(new ForzaDSXReportStruct("Connection closed. Restarting..."));
					Connect();
				}
				else
				{
					if (progressReporter != null)
						progressReporter.Report(new ForzaDSXReportStruct("Unknown Error: " + e.Message));
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
                        progressReporter.Report(new ForzaDSXReportStruct("No active profile selected. Exiting..."));
                    }
                    return;
                }
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
						progressReporter.Report(new ForzaDSXReportStruct("recieved Message from Forza!"));
					}
					//parse data
					//var resultBuffer = receive.Buffer;
					if (!AdjustToBufferType(resultBuffer.Length))
					{
						//  return;
					}
					data = parseDirtData(resultBuffer);

					if (settings.VerboseLevel > VerboseLevel.Limited
						&& progressReporter != null)
					{
						progressReporter.Report(new ForzaDSXReportStruct("Data Parsed"));
					}

					//Process and send data to DSX
					SendData(data);
				}
			}
			catch (Exception e)
			{
				if (progressReporter != null)
				{
					progressReporter.Report(new ForzaDSXReportStruct("Application encountered an exception: " + e.Message));
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
				progressReporter.Report(new ForzaDSXReportStruct($"Cleaning Up"));
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
				progressReporter.Report(new ForzaDSXReportStruct($"Cleanup Finished. Exiting..."));
			}
		}

		static float EWMA(float input, float last, float alpha)
		{
			return (alpha * input) + (1 - alpha) * last;
		}
		static int EWMA(int input, int last, float alpha)
		{
			return (int)Math.Floor(EWMA((float)input, (float)last, alpha));
		}

		DataPacket parseDirtData(byte[] packet)
		{
            DataPacket data = new DataPacket();
			//data.AccelerationX

			data.IsRaceOn = true;
			data.Power = 1;
			data.CurrentEngineRpm = PacketParse.GetSingle(packet, 148) * 10.0f;
			data.Speed = PacketParse.GetSingle(packet, 28);
			data.frontLeftContactPatchV = PacketParse.GetSingle(packet, 108);
            data.TireCombinedSlipFrontLeft = calcTireSlip(PacketParse.GetSingle(packet, 108), data.Speed);
			data.TireCombinedSlipFrontRight = calcTireSlip(PacketParse.GetSingle(packet, 112), data.Speed);
			data.TireCombinedSlipRearLeft = calcTireSlip(PacketParse.GetSingle(packet, 100), data.Speed);
			data.TireCombinedSlipRearRight = calcTireSlip(PacketParse.GetSingle(packet, 104), data.Speed);


            data.CarClass = 0;

			data.CarPerformanceIndex = 0;

                data.AccelerationX = PacketParse.GetSingle(packet, 136);

                data.AccelerationZ = PacketParse.GetSingle(packet, 140);

                data.Accelerator = (uint)(PacketParse.GetSingle(packet, 116)* 255.0f);

                data.Brake = (uint)(PacketParse.GetSingle(packet, 120) * 255.0f);

			data.EngineMaxRpm = PacketParse.GetSingle(packet, 252) * 10.0f;
			data.EngineIdleRpm = 0;
            return data;
        }
		static float calcTireSlip(float contactPatchSpeed, float vehicleSpeed)
		{
			if (Math.Abs(vehicleSpeed) < 0.1f)
			{
                return 0;
            }
			return 3.0f * (Math.Abs(Math.Abs(contactPatchSpeed) - vehicleSpeed) / vehicleSpeed);
		}
        //Parses data from Forza into a DataPacket
        DataPacket ParseData(byte[] packet)
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
		}

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
