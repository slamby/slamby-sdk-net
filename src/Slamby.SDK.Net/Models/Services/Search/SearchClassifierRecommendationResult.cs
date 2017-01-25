using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchClassifierRecommendationResult : ClassifierRecommendationResult
    {
        public bool SearchResultMatch { get; set; }
    }
}
