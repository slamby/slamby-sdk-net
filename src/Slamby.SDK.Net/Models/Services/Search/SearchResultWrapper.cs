using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchResultWrapper
    {
        /// <summary>
        /// List of the AutoComplete suggestions
        /// </summary>
        public List<AutoCompleteResult> AutoCompleteResultList { get; set; }

        /// <summary>
        /// List of the Classifier results of the input text
        /// </summary>
        public List<SearchClassifierRecommendationResult> ClassifierResultList { get; set; }

        /// <summary>
        /// The matched documents with relevance scores
        /// </summary>
        public List<SearchResult> SearchResultList { get; set; }

        /// <summary>
        /// The total matched document count
        /// </summary>
        public int Total { get; set; }


    }

    /// <summary>
    /// Contains a suggestion for the input text
    /// </summary>
    public class AutoCompleteResult
    {
        /// <summary>
        /// The suggested text instead of the original text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The score of the suggestion relevance
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The related Classifier results for this suggested text
        /// </summary>
        public List<SearchClassifierRecommendationResult> ClassifierResultList { get; set; }
    }

    /// <summary>
    /// A search result, actually a document itself with a relevance score
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// The ID of the document
        /// </summary>
        public string DocumentId { get; set; }

        /// <summary>
        /// The relevance score
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The document itself but ONLY the FIELDS that you request with the RESPONSEFIELDLIST parameter
        /// </summary>
        public object Document { get; set; }
    }
    
}
