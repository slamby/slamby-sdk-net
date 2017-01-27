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
        /// <summary>
        /// The AutoComplete settings to activate (as default setting for all search)
        /// For the details of this setting check [AutoCompleteSettings](#/definitions/AutoCompleteSettings)
        /// </summary>
        public AutoCompleteSettings AutoCompleteSettings { get; set; }
        /// <summary>
        /// The Search settings to activate (as default setting for all search)
        /// For the details of this setting check [SearchSettings](#/definitions/SearchSettings)
        /// </summary>
        public SearchSettings SearchSettings { get; set; }
        /// <summary>
        /// The Classifier settings to activate (as default setting for all search)
        /// For the details of this setting check [ClassifierSettings](#/definitions/ClassifierSettings)
        /// </summary>
        public ClassifierSettings ClassifierSettings { get; set; }

    }

    /// <summary>
    /// The AutoComplete settings. The AutoComplete is using the [ElasticSearch Phrase Suggester](https://www.elastic.co/guide/en/elasticsearch/reference/current/search-suggesters-phrase.html)
    /// </summary>
    public class AutoCompleteSettings {
        /// <summary>
        /// The confidence level defines a factor applied to the input phrases score which is used as a threshold for other suggest candidates. Only candidates that score higher than the threshold will be included in the result. For instance a confidence level of 1.0 will only return suggestions that score higher than the input phrase. If set to 0.0 the top N candidates are returned. The default is 1.0.
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double? Confidence { get; set; }

        /// <summary>
        /// The maximum percentage of the terms that at most considered to be misspellings in order to form a correction. This method accepts a float value in the range [0..1) as a fraction of the actual query terms or a number >=1 as an absolute number of query terms. The default is set to 1.0 which corresponds to that only corrections with at most 1 misspelled term are returned
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double? MaximumErrors { get; set; }

        /// <summary>
        /// The number of candidates that are generated for each individual query term. Low numbers like 3 or 5 typically produce good results. Raising this can bring up terms with higher edit distances
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }

    }

    /// <summary>
    /// The Search settings. The search is using ElasticSearch MATCH or QUERYSTRING search. Depends on the Type setting
    /// </summary>
    public class SearchSettings
    {
        /// <summary>
        /// The Filter settings
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// When you activate a Search service with a Filter, you can use this property to control if you want to use that 'default filter' during each searches
        /// </summary>
        public bool? UseDefaultFilter { get; set; }

        /// <summary>
        /// Can use each available dataset field, a preferred value and a weighted score between 0 and 10 to boost the result
        /// </summary>
        public List<Weight> Weights { get; set; }

        /// <summary>
        /// When you activate a Search service with Weights, you can use this property to control if you want to use that 'default weights' during each searches
        /// </summary>
        public bool? UseDefaultWeights { get; set; }

        /// <summary>
        /// Which dataset fields must be in the search response
        /// </summary>
        public List<string> ResponseFieldList { get; set; }

        /// <summary>
        /// In which fields you would liket to search. The list can contains boosts. For example: title^2  which means matches on the title field will have twice the weight as those on the other fields
        /// </summary>
        public List<string> SearchFieldList { get; set; }

        /// <summary>
        /// The type of the search. Can be MATCH (default) which means a simple word based search or can be QUERY which means you can use expressions in the query, like in the [QueryString Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-query-string-query.html#query-string-syntax) in ElasticSearch
        /// </summary>
        public SearchTypeEnum? Type { get; set; }

        /// <summary>
        /// Allows specifying an absolute or relative document frequency where high frequency terms are moved into an optional subquery and are only scored if one of the low frequency (below the cutoff) terms in the case of an OR operator or all of the low frequency terms in the case of an AND operator match
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public double? CutOffFrequency { get; set; }

        /// <summary>
        /// Interpreted as a Levenshtein Edit Distance — the number of one character changes that need to be made to one string to make it the same as another string. Can be specified as: -1 (generates an edit distance based on the length of the term) or 0, 1, 2 (the maximum allowed Levenshtein Edit Distance)
        /// </summary>
        [Range(-1, 2)]
        public int? Fuzziness { get; set; }

        /// <summary>
        /// The maximum number of matches
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }

        /// <summary>
        /// Can be set to OR or AND to control the operators between the text words
        /// For example if the operator is AND, and the query is: 'white mobilephone' then the 'white' AND the 'mobilephone' must be match the documents
        /// If the operator is OR in the same query then one of the query words is enough for a match. Of course if a document matches all the words then that will have a higher score
        /// </summary>
        public LogicalOperatorEnum? Operator { get; set; }

        /// <summary>
        /// You can change the order of the search results. You have to specify a field of the dataset the order (Ascending or Descending)
        /// Be careful with this, if you change the default order then not the most relevant (for the text) documents will be on the top
        /// </summary>
        public Order Order { get; set; }
    }

    /// <summary>
    /// The related Classifier Settings
    /// </summary>
    public class ClassifierSettings
    {
        /// <summary>
        /// The Alias or the ID of the Classifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// How many results the Classifier should response
        /// </summary>
        [Range(0, Constants.ValidationCommonMaximumNumber)]
        public int? Count { get; set; }
    }
}
