using RacingDSX.Config;
using RacingDSX.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RacingDSX.RacingDSXWorker;

namespace RacingDSX.GameParsers
{
    internal class ForzaParser : Parser
    {
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
        public ForzaParser(Config.Config settings) : base(settings)
        {
        }

        public override bool IsRaceOn()
        {
            bool bInRace = data.IsRaceOn;
            float currentRPM = data.CurrentEngineRpm;

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
            return bInRace;
        }

        public override ReportableInstruction GetPreRaceInstructions()
        {
            ReportableInstruction reportableInstruction = new ReportableInstruction();

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


            RightTrigger.Parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
            LeftTrigger.Parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };

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

            LightBar.Parameters = new object[] { controllerIndex, CPIcolorR, CPIcolorG, CPIcolorB };
            #endregion


                reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.NORACE, $"No race going on. Normal Triggers. Car's Class = {currentClass}; CPI = {currentCPI}; CPI Ratio = {cpiRatio}; Color [{CPIcolorR}, {CPIcolorG}, {CPIcolorB}]"));
            

            reportableInstruction.Instructions = new Instruction[] { LightBar, LeftTrigger, RightTrigger };
            return reportableInstruction;
        }


        public override void ParsePacket(byte[] packet)
        {
            data = new DataPacket();



            // sled
            data.IsRaceOn = packet.IsRaceOn();
            data.EngineMaxRpm = packet.EngineMaxRpm();
            data.EngineIdleRpm = packet.EngineIdleRpm();
            data.CurrentEngineRpm = packet.CurrentEngineRpm();
            data.AccelerationX = packet.AccelerationX();
            data.AccelerationZ = packet.AccelerationZ();
         
            data.TireCombinedSlipFrontLeft = packet.TireCombinedSlipFl();
            data.TireCombinedSlipFrontRight = packet.TireCombinedSlipFr();
            data.TireCombinedSlipRearLeft = packet.TireCombinedSlipRl();
            data.TireCombinedSlipRearRight = packet.TireCombinedSlipRr();

            data.CarClass = packet.CarClass();
            data.CarPerformanceIndex = packet.CarPerformanceIndex();

            data.Speed = packet.Speed();
            data.Power = packet.Power();

            data.Accelerator = packet.Accelerator();
            data.Brake = packet.Brake();


            data.FourWheelCombinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight) + Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 4;
           data.FrontWheelsCombinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight)) / 2;
           data.RearWheelsCombinedTireSlip = (Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 2;


           /* data.TimestampMS = packet.TimestampMs();
            data.AccelerationY = packet.AccelerationY();

            data.SuspensionTravelMetersFrontLeft = packet.SuspensionTravelMetersFl();
            data.SuspensionTravelMetersFrontRight = packet.SuspensionTravelMetersFr();
            data.SuspensionTravelMetersRearLeft = packet.SuspensionTravelMetersRl();
            data.SuspensionTravelMetersRearRight = packet.SuspensionTravelMetersRr();
            data.CarOrdinal = packet.CarOrdinal();
            data.DrivetrainType = packet.DriveTrain();
            data.NumCylinders = packet.NumCylinders();

            // dash
            data.PositionX = packet.PositionX();
            data.PositionY = packet.PositionY();
            data.PositionZ = packet.PositionZ();
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
            data.Clutch = packet.Clutch();
            data.Handbrake = packet.Handbrake();
            data.Gear = packet.Gear();
            data.Steer = packet.Steer();
            data.NormalDrivingLine = packet.NormalDrivingLine();
            data.NormalAiBrakeDifference = packet.NormalAiBrakeDifference();
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
            return data;
            throw new NotImplementedException();*/
        }
    }
}
