using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Contains calculated values for the tag
    /// </summary>
    public class TagProperties
    {
        /// <summary>
        /// A tag list contains parent path elements
        /// </summary>
        public List<PathItem> Paths { get; set; } = new List<PathItem>();

        /// <summary>
        /// The level of the tag in the hierarchy (root level is: 0)
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// If the tag is a leaf tag. Leaf tag means the tag is not a parent of any other tags
        /// </summary>
        public bool IsLeaf { get; set; }

        /// <summary>
        /// Document count for the tag
        /// </summary>
        public int DocumentCount { get; set; }

        /// <summary>
        /// Word count for the tag
        /// </summary>
        public int WordCount { get; set; }
    }
}
