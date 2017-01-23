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
        public double? Confidence { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double? MaximumErrors { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }

    }

    public class SearchSettings
    {
        public Filter Filter { get; set; }

        public List<Weight> Weights { get; set; }

        public List<string> ResponseFieldList { get; set; }

        //can contains e.g.: ^2 boost
        public List<string> SearchFieldList { get; set; }

        public SearchTypeEnum? Type { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double? CutOffFrequency { get; set; }

        [Range(-1, 2)]
        public int? Fuzziness { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }

        public LogicalOperatorEnum? Operator { get; set; }
    }

    public class ClassifierSettings
    {
        public string Id { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }
    }
}
