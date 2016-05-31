using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        [Required]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Query returns only with Id field values
        /// </summary>
        public bool IdsOnly { get; set; }

        public Filter Filter { get; set; }
    }
}
