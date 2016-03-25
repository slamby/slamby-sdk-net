using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class Tag
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string  Name { get; set; }
        public string ParentId { get; set; }
        public TagProperties Properties { get; set; }
    }
}
