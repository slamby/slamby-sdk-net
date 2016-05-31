using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Stores complete tag hierarchy for bulk insert
    /// </summary>
    public class TagBulkSettings
    {
        /// <summary>
        /// The complete tag hierarchy array
        /// </summary>
        [Required]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagBulkSettings"/> class.
        /// </summary>
        public TagBulkSettings()
        {
            Tags = new List<Tag>();
        }
    }
}
