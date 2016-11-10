using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Change Secret model
    /// </summary>
    public class ChangeSecret
    {
        /// <summary>
        /// New secret to be set
        /// </summary>
        [Required]
        public string NewSecret { get; set; }
    }
}
