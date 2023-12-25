using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    internal class ThrottleSettings
    {
        internal TriggerMode TriggerMode { get; set; } = TriggerMode.Vibration;
        internal float GripLossValue { get; set; } = 0.2f;
        internal float EffectIntensity { get; set; } = 0.9f;
        internal float TurnAccelerationScale { get; set; } = 0.5f;
        internal float ForwardAccelerationScale { get; set; } = 1.0f;
        internal int AccelerationLimit { get; set; } = 10;
        internal int VibrationModeStart { get; set; } = 5;
        internal int MinVibration { get; set; } = 3;
        internal int MaxVibration { get; set; } = 35;
        internal float VibrationSmoothing { get; set; } = 0.5f;
        internal int MinStiffness { get; set; } = 200;
        internal int MaxStiffness { get; set; } = 75;
        internal int MinResistance { get; set; } = 1;
        internal int MaxResistance { get; set; } = 6;
        internal float ResistanceSmoothing { get; set; } = 0.01f;

    }
}
