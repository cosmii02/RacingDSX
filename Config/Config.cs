using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    internal class Config
    {
        internal bool DisableAppCheck { get; set; }
        internal VerboseLevel VerboseLevel { get; set; } = VerboseLevel.Off;
        internal Dictionary<String, Profile> Profiles { get; set; } = new Dictionary<String, Profile>();

    }
}
