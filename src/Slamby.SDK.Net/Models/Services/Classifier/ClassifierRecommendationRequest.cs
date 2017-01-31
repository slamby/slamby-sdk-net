using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierRecommendationRequest
    {
        /// <summary>
        /// The text the you want to classify
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// How many results you want to see in the response (default value is 3)
        /// </summary>
        public int Count { get; set; } = 3;

        /// <summary>
        /// Use emphasizing algorithm during this recommendation
        /// </summary>
        public bool UseEmphasizing { get; set; }

        /// <summary>
        /// If you want to see all the tag object in the response
        /// </summary>
        public bool NeedTagInResult { get; set; }

        /// <summary>
        /// The recommendation process will be used only tags by these parent(s)
        /// </summary>
        public List<string> ParentTagIdList { get; set; } = new List<string>();
    }
}
