using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        [Required]
        public Pagination Pagination { get; set; }

        public Filter Filter { get; set; }

        /// <summary>
        /// Query returns only with the specified field(s)
        /// </summary>
        public FieldFilter FieldFilter { get; set; }
    }
}
