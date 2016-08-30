using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        [Required]
        public Pagination Pagination { get; set; }

        public Order Order { get; set; }

        public Filter Filter { get; set; }

        /// <summary>
        /// Query returns only with the specified field(s)
        /// </summary>
        public List<string> FieldList { get; set; } = new List<string>();
    }
}
