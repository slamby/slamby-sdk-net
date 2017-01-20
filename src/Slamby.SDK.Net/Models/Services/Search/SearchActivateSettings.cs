using Slamby.SDK.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchActivateSettings
    {
        /// <summary>
        /// How many results you want to see in the response. This is a default value setting. The default is 3
        /// </summary>
        public int Count { get; set; } = 3;
        public AutoCompleteSettings AutoCompleteSettings { get; set; }

        public SearchSettings SearchSettings { get; set; }

        public ClassifierSettings ClassifierSettings { get; set; }

    }

    public class AutoCompleteSettings {
        public double Confidence { get; set; } = 2.0;

        public double MaximumErrors { get; set; } = 0.5;

        public int Count { get; set; }

    }

    public class SearchSettings
    {
        public Filter Filter { get; set; }

        public List<Weight> Weights { get; set; } = new List<Weight>();

        public List<string> ResponseFieldList { get; set; } = new List<string>();

        //can contains e.g.: ^2 boost
        public List<string> SearchFieldList { get; set; } = new List<string>();

        public SearchTypeEnum Type { get; set; }

        public double CutOffFrequency { get; set; } = 0.001;

        public int Fuzziness { get; set; } = -1;

        public int Count { get; set; }

        public LogicalOperatorEnum Operator { get; set; } = LogicalOperatorEnum.OR;
    }

    public class ClassifierSettings
    {
        public string Id { get; set; }

        public int Count { get; set; }
    }
}
