using Slamby.SDK.Net.Models.Enums;

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
