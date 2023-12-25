using ForzaDSX.GameParsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    internal class Profile
    {
        internal GameTypes GameType { get; set; } = GameTypes.None;
        internal bool IsEnabled { get; set; } = true;
        internal string Name { get; set; }
        internal uint gameUDPPort { get; set; }
        internal List<string> executableNames { get; set; } = new List<string>();
        internal ThrottleSettings throttleSettings { get; set; } = new ThrottleSettings();
        internal BrakeSettings brakeSettings { get; set; } = new BrakeSettings();
    }
}
