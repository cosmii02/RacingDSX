using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDSX.GameParsers
{
    internal class NullParser : Parser
    {
        public NullParser(Config.Config settings) : base(settings)
        {
        }

        public override void ParsePacket(byte[] packet)
        {
            data = new DataPacket();
            //data.AccelerationX

            data.IsRaceOn = true;
            data.Power = 1;
            data.CurrentEngineRpm = 0;
            data.Speed = 0;
            data.TireCombinedSlipFrontLeft = 0;
            data.TireCombinedSlipFrontRight = 0;
            data.TireCombinedSlipRearLeft = 0;
            data.TireCombinedSlipRearRight = 0;
        }
    }
}
