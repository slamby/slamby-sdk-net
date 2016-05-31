namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierRecommendationResult
    {
        /// <summary>
        /// The recommended tag id
        /// </summary>
        public string TagId { get; set; }
        
        /// <summary>
        /// The score that belongs to the tag id
        /// </summary>
        public double Score { get; set; }

        public Tag Tag { get; set; }
    }
}
