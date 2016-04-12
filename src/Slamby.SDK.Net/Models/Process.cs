using Slamby.SDK.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models
{
    public class Process
    {
        public string Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Percent { get; set; }
        public ProcessStatusEnum Status { get; set; }
        public ProcessTypeEnum Type { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
