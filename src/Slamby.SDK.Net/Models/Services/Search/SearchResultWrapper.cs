using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchResultWrapper
    {
        public List<AutoCompleteResult> AutoCompleteResultList { get; set; }

        public List<ClassifierRecommendationResult> ClassifierResultList { get; set; }

        public List<SearchResult> SearchResultList { get; set; }


    }

    public class AutoCompleteResult
    {
        public string Text { get; set; }

        public string TagId { get; set; }

        public double Score { get; set; }

        public Tag Tag { get; set; }
    }

    public class SearchResult
    {
        public string DocumentId { get; set; }

        public double Score { get; set; }

        public object Document { get; set; }
    }
    
}
