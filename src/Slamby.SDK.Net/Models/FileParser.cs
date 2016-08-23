using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// File parser request
    /// </summary>
    public class FileParser
    {
        /// <summary>
        /// Valid base64 document content
        /// </summary>
        [Required]
        public string Content { get; set; }
    }
}
