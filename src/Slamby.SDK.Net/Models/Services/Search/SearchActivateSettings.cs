using Slamby.SDK.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchActivateSettings
    {
        public AutoCompleteSettings AutoCompleteSettings { get; set; }
        public SearchSettings SearchSettings { get; set; }
        public ClassifierSettings ClassifierSettings { get; set; }

    }

    public class AutoCompleteSettings {
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double Confidence { get; set; } = 2.0;

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double MaximumErrors { get; set; } = 0.5;

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int Count { get; set; }

    }

    public class SearchSettings
    {
        public Filter Filter { get; set; }

        public List<Weight> Weights { get; set; } = new List<Weight>();

        public List<string> ResponseFieldList { get; set; } = new List<string>();

        //can contains e.g.: ^2 boost
        public List<string> SearchFieldList { get; set; } = new List<string>();

        public SearchTypeEnum Type { get; set; } = SearchTypeEnum.Match;

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double CutOffFrequency { get; set; } = 0.001;

        [Range(-1, 2)]
        public int Fuzziness { get; set; } = -1;

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int Count { get; set; }

        public LogicalOperatorEnum Operator { get; set; } = LogicalOperatorEnum.OR;
    }

    public class ClassifierSettings
    {
        [Required]
        public string Id { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int Count { get; set; }
    }
}
