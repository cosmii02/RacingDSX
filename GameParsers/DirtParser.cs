using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.GameParsers
{
    internal class DirtParser : Parser
    {
        public DirtParser(Config.Config settings) : base(settings)
        {
        }

        public override void ParsePacket(byte[] packet)
        {
            data = new DataPacket();
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

            data.Accelerator = (uint)(PacketParse.GetSingle(packet, 116) * 255.0f);

            data.Brake = (uint)(PacketParse.GetSingle(packet, 120) * 255.0f);

            data.EngineMaxRpm = PacketParse.GetSingle(packet, 252) * 10.0f;
            data.EngineIdleRpm = 0;
            data.FourWheelCombinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight) + Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 4;
            data.FrontWheelsCombinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight)) / 2;
            data.RearWheelsCombinedTireSlip = (Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 2;
        }
        static float calcTireSlip(float contactPatchSpeed, float vehicleSpeed)
        {
            if (Math.Abs(vehicleSpeed) < 0.1f)
            {
                return 0;
            }
            return 3.0f * (Math.Abs(Math.Abs(contactPatchSpeed) - vehicleSpeed) / vehicleSpeed);
        }

    }
}
