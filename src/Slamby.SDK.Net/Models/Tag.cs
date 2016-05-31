using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Tag object
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// The identifier of the tag. It must be unique accross the DataSet
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// "Name of the tag
        /// </summary>
        [Required]
        public string  Name { get; set; }

        /// <summary>
        /// The identifier of the parent of the tag. It must be the id of an existing tag
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Tag properties
        /// </summary>
        public TagProperties Properties { get; set; }
    }
}
