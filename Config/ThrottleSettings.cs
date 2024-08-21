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
        public float GripLossValue { get; set; } = 0.6f;
        public float EffectIntensity { get; set; } = 1.0f;
        public float TurnAccelerationScale { get; set; } = 0.25f;
        public float ForwardAccelerationScale { get; set; } = 1.0f;
        public int AccelerationLimit { get; set; } = 10;
        public int VibrationModeStart { get; set; } = 5;
        public int MinVibration { get; set; } = 5;
        public int MaxVibration { get; set; } = 55;
        public float VibrationSmoothing { get; set; } = 1f;
        public int MinStiffness { get; set; } = 255;
        public int MaxStiffness { get; set; } = 175;
        public int MinResistance { get; set; } = 0;
        public int MaxResistance { get; set; } = 3;
        public float ResistanceSmoothing { get; set; } = 0.9f;

    }
}
