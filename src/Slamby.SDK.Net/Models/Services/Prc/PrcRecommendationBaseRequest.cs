using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcRecommendationBaseRequest
    {
        public int Count { get; set; } = 3;

        public bool NeedDocumentInResult { get; set; }

        public string TagId { get; set; }

        public List<Weight> Weights { get; set; } = new List<Weight>();
    }
}
