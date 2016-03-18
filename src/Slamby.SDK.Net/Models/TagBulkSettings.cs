using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class TagBulkSettings
    {
        [Required]
        public List<Tag> Tags { get; set; }

        public TagBulkSettings()
        {
            Tags = new List<Tag>();
        }
    }
}
