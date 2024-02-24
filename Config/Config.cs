using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ForzaDSX.Config
{
    public class Config
    {
        public bool DisableAppCheck { get; set; }
        public VerboseLevel VerboseLevel { get; set; } = VerboseLevel.Off;
        public Dictionary<String, Profile> Profiles { get; set; } = new Dictionary<String, Profile>();
        [JsonIgnore]
        public Profile ActiveProfile { get; set; } = null;

        public int DSXPort { get; set; } = 6969;

        public String DefaultProfile { get; set; } = "Forza";
    }
}
