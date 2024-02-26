namespace RacingDSX
{
    public class CsvData
    {
        public uint time { get; set; }
        public float AccelerationX { get; set; }
        public float AccelerationY { get; set; }
        public float AccelerationZ { get; set; }
        public float Brake { get; set; }
        public float TireCombinedSlipFrontLeft { get; set; }
        public float TireCombinedSlipFrontRight { get; set; }
        public float TireCombinedSlipRearLeft { get; set; }
        public float TireCombinedSlipRearRight { get; set; }
        public float combinedTireSlip { get; set; }
        public float AverageAcceleration { get; set; }
        public float CurrentEngineRpm { get; set; }
        public int ThrottleResistance { get; set; }
        public int ThrottleResistance_filtered { get; set; }
        public int BrakeResistance { get; set; }
        public int BrakeResistance_filtered { get; set; }
        public int BrakeVibrationFrequency { get; set; }
        public int BrakeVibrationFrequency_freq { get; set; }
    }
}