using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcRecommendationByIdRequest : PrcRecommendationBaseRequest
    {
        [Required]
        public string DocumentId { get; set; }
    }
}
