using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        [Required]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Identifier for the next series of items
        /// </summary>
        public string ScrollId { get; set; }

        public Order Order { get; set; }

        public Filter Filter { get; set; }

        /// <summary>
        /// Query returns only with the specified field(s)
        /// </summary>
        public List<string> Fields { get; set; } = new List<string>();
    }
}
