using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchClassifierRecommendationResult : ClassifierRecommendationResult
    {
        /// <summary>
        /// If the recommended category is matched any of the search-matched documents categories
        /// </summary>
        public bool SearchResultMatch { get; set; }
    }
}
