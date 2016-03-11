using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentBulkSettings
    {
        [Required]
        public List<object> Documents { get; set; }

        public DocumentBulkSettings()
        {
            Documents = new List<object>();
        }
    }
}
