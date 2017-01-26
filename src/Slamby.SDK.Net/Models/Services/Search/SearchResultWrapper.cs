using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchResultWrapper
    {
        public List<AutoCompleteResult> AutoCompleteResultList { get; set; }

        public List<SearchClassifierRecommendationResult> ClassifierResultList { get; set; }

        public List<SearchResult> SearchResultList { get; set; }

        public int Total { get; set; }


    }

    public class AutoCompleteResult
    {
        public string Text { get; set; }

        public double Score { get; set; }

        public List<SearchClassifierRecommendationResult> ClassifierResultList { get; set; }
    }

    public class SearchResult
    {
        public string DocumentId { get; set; }

        public double Score { get; set; }

        public object Document { get; set; }
    }
    
}
