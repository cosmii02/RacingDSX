using ForzaDSX.GameParsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    public class Profile
    {
        public GameTypes GameType { get; set; } = GameTypes.None;
        public bool IsEnabled { get; set; } = true;
        public string Name { get; set; }
        public int gameUDPPort { get; set; }
        public List<string> executableNames { get; set; } = new List<string>();
        public ThrottleSettings throttleSettings { get; set; } = new ThrottleSettings();
        public BrakeSettings brakeSettings { get; set; } = new BrakeSettings();

        public float RPMRedlineRatio { get; set; } = 0.9f;
    }
}
