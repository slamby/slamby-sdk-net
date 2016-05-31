using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class ExportDictionariesSettings
    {
        public List<string> TagIdList { get; set; }
        public List<int> NGramList { get; set; }
    }
}
