using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchRequest
    {
        /// <summary>
        /// A simple text or a Query String query, depends on the Type of the search
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// You can override the activated AutoCompleteSettings during each search. Null means the activated settings will be used
        /// </summary>
        public AutoCompleteSettings AutoCompleteSettings { get; set; }
        /// <summary>
        /// You can override the activated SearchSettings during each search. Null means the activated settings will be used
        /// </summary>
        public SearchSettings SearchSettings { get; set; }
        /// <summary>
        /// You can override the activated ClassifierSettings during each search. Null means the activated settings will be used
        /// </summary>
        public ClassifierSettings ClassifierSettings { get; set; }
    }
}
