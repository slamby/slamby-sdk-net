using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcRecommendationResult
    {
        public string DocumentId { get; set; }
        public double Score { get; set; }
        public object Document { get; set; }
    }
}
