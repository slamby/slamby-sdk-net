using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TagsExportWordsSettings
    {
        public List<string> TagIdList { get; set; } = new List<string>();

        [Required]
        [Range(1, 6)]
        public List<int> NGramList { get; set; } = new List<int>();
    }
}
