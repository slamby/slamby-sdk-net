using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierRecommendationResult
    {
        public string TagId { get; set; }
        public double Score { get; set; }
        public Tag Tag { get; set; }
    }
}
