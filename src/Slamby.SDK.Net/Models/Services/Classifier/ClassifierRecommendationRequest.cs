using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierRecommendationRequest
    {
        [Required]
        public string Text { get; set; }

        public int Count { get; set; } = 3;

        public bool UseEmphasizing { get; set; }

        public bool NeedTagInResult { get; set; }
    }
}
