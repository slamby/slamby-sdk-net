using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentFilterSettings
    {
        public List<string> TagIds { get; set; }
        [Required]
        public Pagination Pagination { get; set; }

        public Dictionary<string, string> QueryDictionary { get; set; }
    }
}
