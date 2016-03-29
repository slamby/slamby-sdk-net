using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        [Required]
        public Pagination Pagination { get; set; }

        public bool IdsOnly { get; set; }

        public Filter Filter { get; set; }
    }
}
