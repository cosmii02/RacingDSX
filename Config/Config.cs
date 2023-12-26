using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    public class Config
    {
        public bool DisableAppCheck { get; set; }
        public VerboseLevel VerboseLevel { get; set; } = VerboseLevel.Off;
        public Dictionary<String, Profile> Profiles { get; set; } = new Dictionary<String, Profile>();

        public Profile ActiveProfile { get; set; } = null;

        public int DSXPort { get; set; } = 6900;
    }
}
