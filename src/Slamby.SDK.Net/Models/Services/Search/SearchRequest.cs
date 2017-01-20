using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchRequest
    {
        [Required]
        public string Text { get; set; }

        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int Count { get; set; }

        public AutoCompleteSettings AutoCompleteSettings { get; set; }

        public SearchSettings SearchSettings { get; set; }

        public ClassifierSettings ClassifierSettings { get; set; }

    }
}
