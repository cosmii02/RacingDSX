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

        public float EffectIntensity { get; set; } = 0.7f;

        public float GripLossValue { get; set; } = 0.5f;
        public int VibrationStart { get; set; } = 20;
        public int VibrationModeStart { get; set; } = 10;
        public int MinVibration { get; set; } = 3;
        public int MaxVibration { get; set; } = 35;
        public float VibrationSmoothing { get; set; } = 1f;
        public int MinStiffness { get; set; } = 200;
        public int MaxStiffness { get; set; } = 1;
        public int MinResistance { get; set; } = 1;
        public int MaxResistance { get; set; } = 6;
        public float ResistanceSmoothing { get; set; } = 1f;
    }
}
