using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class FieldFilter
    {
        /// <summary>
        /// Response document fields can be defined.
        /// If this property is empty, by default Id, Tag, Interpreted fields will be included.
        /// </summary>
        public List<string> IncludeFields { get; set; } = new List<string>();
    }
}
