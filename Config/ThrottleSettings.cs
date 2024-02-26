using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDSX.Config
{
    public class ThrottleSettings
    {
        public TriggerMode TriggerMode { get; set; } = TriggerMode.Vibration;
        public float GripLossValue { get; set; } = 0.2f;
        public float EffectIntensity { get; set; } = 0.9f;
        public float TurnAccelerationScale { get; set; } = 0.5f;
        public float ForwardAccelerationScale { get; set; } = 1.0f;
        public int AccelerationLimit { get; set; } = 10;
        public int VibrationModeStart { get; set; } = 5;
        public int MinVibration { get; set; } = 3;
        public int MaxVibration { get; set; } = 35;
        public float VibrationSmoothing { get; set; } = 0.5f;
        public int MinStiffness { get; set; } = 200;
        public int MaxStiffness { get; set; } = 75;
        public int MinResistance { get; set; } = 1;
        public int MaxResistance { get; set; } = 6;
        public float ResistanceSmoothing { get; set; } = 0.01f;

    }
}
