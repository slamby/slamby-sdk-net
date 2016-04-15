using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcRecommendationRequest
    {
        [Required]
        public string Text { get; set; }

        public int Count { get; set; } = 3;

        public bool NeedDocumentInResult { get; set; }

        [Required]
        public string TagId { get; set; }

        public Filter Filter { get; set; }
        public List<Weight> Weights { get; set; }
    }
}
