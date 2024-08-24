using RacingDSX.Config;
using RacingDSX.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RacingDSX.RacingDSXWorker;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RacingDSX.GameParsers
{
    public abstract class Parser
    {
       // Packet p = new Packet();
        protected Instruction RightTrigger = new Instruction(InstructionType.TriggerUpdate);
        protected Instruction LeftTrigger = new Instruction(InstructionType.TriggerUpdate);
        protected Instruction LightBar = new Instruction(InstructionType.RGBUpdate);
        protected int controllerIndex = 0;
        protected DataPacket data;
        protected RacingDSX.Config.Config settings;
        protected RacingDSX.Config.Profile activeProfile;


        protected int lastThrottleResistance = 1;
        protected int lastThrottleFreq = 0;
        protected int lastBrakeResistance = 200;
        protected int lastBrakeFreq = 0;

        protected uint LastValidCarClass = 0;
        protected int LastValidCarCPI = 0;
        protected float MaxCPI = 255;

        protected float LastEngineRPM = 0;
        // FH does not always correctly set IsRaceOn, so we must also check if the RPM info is the same for a certain ammount of time
        protected uint LastRPMAccumulator = 0;
        protected uint RPMAccumulatorTriggerRaceOff = 200;


        protected Parser(RacingDSX.Config.Config settings) {
            this.settings = settings;
            activeProfile = settings.ActiveProfile;
        }
        public virtual bool IsRaceOn()
        {
            return true;
        }

        public virtual ReportableInstruction GetPreRaceInstructions()
        {
            ReportableInstruction p = new ReportableInstruction();
            RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
            LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };
            LightBar.parameters = new object[] { controllerIndex, 220, 120, 220};
            p.Instructions = new Instruction[] { LightBar, LeftTrigger, RightTrigger };

            return p;
        }

        public virtual ReportableInstruction GetInRaceLightbarInstruction()
        {
            ReportableInstruction reportableInstruction = new ReportableInstruction();

            // Calculate RPM ratio
            float engineRange = data.EngineMaxRpm - data.EngineIdleRpm;
            float CurrentRPMRatio = (data.CurrentEngineRpm - data.EngineIdleRpm) / engineRange;

            // Calculate color based on RPM
            int RedChannel = (int)Math.Floor(CurrentRPMRatio * 255);
            int GreenChannel = Math.Max((int)Math.Floor((1 - CurrentRPMRatio) * 255), 50);
            int BlueChannel = 0;
            int Brightness = 255;

            // Check for redline
            if (CurrentRPMRatio >= activeProfile.RPMRedlineRatio)
            {
                RedChannel = 255;
                GreenChannel = 0;
                BlueChannel = 0;
            }

            // Set LightBar instruction
            LightBar.parameters = new object[] { controllerIndex, RedChannel, GreenChannel, BlueChannel, Brightness };

            // Add report for verbose output
            reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(
                VerboseLevel.Full, 
                $"Engine RPM: {data.CurrentEngineRpm}; Engine Max RPM: {data.EngineMaxRpm}; Engine Idle RPM: {data.EngineIdleRpm}; " +
                $"RPM Ratio: {CurrentRPMRatio:F2}; Light Color: R{RedChannel} G{GreenChannel} B{BlueChannel}"
            ));

            // Set instructions
            reportableInstruction.Instructions = new Instruction[] { LightBar };

            return reportableInstruction;
        }
        public virtual ReportableInstruction GetInRaceLeftTriggerInstruction()
        {
            ReportableInstruction reportableInstruction = new ReportableInstruction();

            int resistance = 0;
            int filteredResistance = 0;
            float avgAccel = 0;
            int freq = 0;
            int filteredFreq = 0;
            //Update the left(Brake) trigger
            BrakeSettings brakeSettings = activeProfile.brakeSettings;
            // Define losing grip as tires slipping while braking a fair ammount
            bool bLosingBrakeGrip = data.FourWheelCombinedTireSlip > brakeSettings.GripLossValue && data.Brake > 100;

            if (brakeSettings.TriggerMode == Config.TriggerMode.Off)
            {
                LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };
            }
            // If losing grip, start to "vibrate"
            else if (bLosingBrakeGrip && brakeSettings.TriggerMode == Config.TriggerMode.Vibration)
            {
                freq = (int)Math.Floor(Map(data.FourWheelCombinedTireSlip, brakeSettings.GripLossValue, 5, 0, brakeSettings.MaxVibration));
                resistance = (int)Math.Floor(Map(data.Brake, 0, 255, brakeSettings.MaxStiffness, brakeSettings.MinStiffness));
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
                reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.BRAKE_VIBRATION, $"Setting Brake to vibration mode with freq: {filteredFreq}\r\n Resistance: {filteredResistance}"));
                
            }
            else
            {
                //By default, Increasingly resistant to force
                resistance = (int)Math.Floor(Map(data.Brake, 0, 255, brakeSettings.MinResistance, brakeSettings.MaxResistance));
                filteredResistance = (int)EWMA(resistance, lastBrakeResistance, brakeSettings.ResistanceSmoothing);
                lastBrakeResistance = filteredResistance;

                LeftTrigger.parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Resistance, 0, filteredResistance * brakeSettings.EffectIntensity };

                reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.BRAKE_VIBRATION, ""));
                
            }


               reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.BRAKE, $"Brake: {data.Brake}\r\n Brake Resistance: {filteredResistance}\r\n Tire Slip: {data.FourWheelCombinedTireSlip} \r\n FLCPS: {data.frontLeftContactPatchV} \r\n speed: {data.Speed}"));
            
            reportableInstruction.Instructions = new Instruction[] { LeftTrigger };
            return reportableInstruction;

        }
        public virtual ReportableInstruction GetInRaceRightTriggerInstruction()
        {

            ReportableInstruction reportableInstruction = new ReportableInstruction();
            int resistance = 0;
            int filteredResistance = 0;
            float avgAccel = 0;
            int freq = 0;
            int filteredFreq = 0;

            //Set the updates for the right Trigger(Throttle)
            ThrottleSettings throttleSettings = activeProfile.throttleSettings;
            avgAccel = (float)Math.Sqrt((throttleSettings.TurnAccelerationScale * (data.AccelerationX * data.AccelerationX)) + (throttleSettings.ForwardAccelerationScale * (data.AccelerationZ * data.AccelerationZ)));

            // Define losing grip as front tires slipping or rear tires slipping while accelerating a fair ammount
            bool bLosingAccelGrip =
            data.FrontWheelsCombinedTireSlip > throttleSettings.GripLossValue
            || (data.RearWheelsCombinedTireSlip > throttleSettings.GripLossValue && data.Accelerator > 200);

            if (throttleSettings.TriggerMode == Config.TriggerMode.Off)
            {
                RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
            }
            // If losing grip, start to "vibrate"
            else if (bLosingAccelGrip && throttleSettings.TriggerMode == Config.TriggerMode.Vibration)
            {
                freq = (int)Math.Floor(Map(data.FourWheelCombinedTireSlip, throttleSettings.GripLossValue, 5, 0, throttleSettings.MaxVibration));
                resistance = (int)Math.Floor(Map(avgAccel, 0, throttleSettings.AccelerationLimit, throttleSettings.MinStiffness, throttleSettings.MaxStiffness));
                filteredResistance = (int)EWMA(resistance, lastThrottleResistance, throttleSettings.ResistanceSmoothing);
                filteredFreq = (int)EWMA(freq, lastThrottleFreq, throttleSettings.VibrationSmoothing);

                lastThrottleResistance = filteredResistance;
                lastThrottleFreq = filteredFreq;

                if (filteredFreq <= throttleSettings.MinVibration
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

                reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.THROTTLE_VIBRATION, $"Setting Throttle to vibration mode with freq: {filteredFreq}\r\n Resistance: {filteredResistance}"));
                
            }
            else
            {
                //It should probably always be uniformly stiff
                resistance = (int)Math.Floor(Map(avgAccel, 0, throttleSettings.AccelerationLimit, throttleSettings.MinResistance, throttleSettings.MaxResistance));
                filteredResistance = (int)EWMA(resistance, lastThrottleResistance, throttleSettings.ResistanceSmoothing);

                lastThrottleResistance = filteredResistance;
                RightTrigger.parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Resistance, 0, filteredResistance * throttleSettings.EffectIntensity };

                reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.THROTTLE_VIBRATION, ""));
                
            }
            reportableInstruction.RacingDSXReportStructs.Add(new RacingDSXReportStruct(VerboseLevel.Limited, RacingDSXReportStruct.ReportType.RACING, RacingDSXReportStruct.RacingReportType.THROTTLE, $"Average Acceleration: {avgAccel}\r\n Throttle Resistance: {filteredResistance}\r\n Accelerator: {data.Accelerator}"));
            

            reportableInstruction.Instructions = new Instruction[] { RightTrigger };

            return reportableInstruction;
        }

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

        static float EWMA(float input, float last, float alpha)
        {
            return (alpha * input) + (1 - alpha) * last;
        }
        static int EWMA(int input, int last, float alpha)
        {
            return (int)Math.Floor(EWMA((float)input, (float)last, alpha));
        }

        public abstract void ParsePacket(byte[] packet);

    }
}
