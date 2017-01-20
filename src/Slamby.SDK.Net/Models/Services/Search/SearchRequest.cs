using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchRequest
    {
        [Required]
        public string Text { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int AutoCompleteCount { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int SearchCount { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int ClassifierCount { get; set; }
    }
}
