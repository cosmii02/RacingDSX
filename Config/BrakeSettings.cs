using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDSX.Config
{
    public class BrakeSettings
    {
        public TriggerMode TriggerMode { get; set; } = TriggerMode.Vibration;

        public float EffectIntensity { get; set; } = 1.0f;

        public float GripLossValue { get; set; } = 0.05f;
        public int VibrationStart { get; set; } = 0;
        public int VibrationModeStart { get; set; } = 30;
        public int MinVibration { get; set; } = 15;
        public int MaxVibration { get; set; } = 20;
        public float VibrationSmoothing { get; set; } = 1.0f;
        public int MinStiffness { get; set; } = 150;
        public int MaxStiffness { get; set; } = 5;
        public int MinResistance { get; set; } = 0;
        public int MaxResistance { get; set; } = 7;
        public float ResistanceSmoothing { get; set; } = 0.4f;
    }
}
