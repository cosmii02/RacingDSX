using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    internal class BrakeSettings
    {
        internal TriggerMode TriggerMode { get; set; } = TriggerMode.Vibration;

        internal float EffectIntensity { get; set; } = 0.7f;

        internal float GripLossValue { get; set; } = 0.5f;
        internal int VibrationStart { get; set; } = 20;
        internal int VibrationModeStart { get; set; } = 10;
        internal int MinVibration { get; set; } = 3;
        internal int MaxVibration { get; set; } = 35;
        internal float VibrationSmoothing { get; set; } = 1f;
        internal int MinStiffness { get; set; } = 200;
        internal int MaxStiffness { get; set; } = 1;
        internal int MinResistance { get; set; } = 1;
        internal int MaxResistance { get; set; } = 6;
        internal float ResistanceSmoothing { get; set; } = 1f;
    }
}
