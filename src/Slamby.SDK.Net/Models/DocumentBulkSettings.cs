using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentBulkSettings
    {
        /// <summary>
        /// Array of the documents to be saved
        /// </summary>
        [Required]
        public List<object> Documents { get; set; } = new List<object>();
    }
}
