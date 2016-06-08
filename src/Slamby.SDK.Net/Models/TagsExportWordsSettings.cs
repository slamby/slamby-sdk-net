using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TagsExportWordsSettings
    {
        public List<string> TagIdList { get; set; }

        [Required]
        public List<int> NGramList { get; set; }
    }
}
