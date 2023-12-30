using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDSX.GameParsers
{
    public class ReportableInstruction
    {
        public Instruction[] Instructions { get; set; }
        public List<ForzaDSXWorker.ForzaDSXReportStruct> ForzaDSXReportStructs { get; set; } = new List<ForzaDSXWorker.ForzaDSXReportStruct>();
    }
}
