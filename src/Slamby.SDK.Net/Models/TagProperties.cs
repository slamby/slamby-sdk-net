using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class TagProperties
    {
        public List<PathItem> Path { get; set; } = new List<PathItem>();
        public int Level { get; set; }
        public bool IsLeaf { get; set; }
        public int DocumentCount { get; set; }
        public int WordCount { get; set; }
    }
}
