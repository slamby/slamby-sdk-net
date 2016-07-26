using Slamby.SDK.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class CompressSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public int CategoryOccurence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DataSetOccurence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LogicalOperatorEnum Operator { get; set; }
    }
}
