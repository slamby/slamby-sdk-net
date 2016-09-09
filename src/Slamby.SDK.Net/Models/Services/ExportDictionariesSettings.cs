using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class ExportDictionariesSettings
    {
        public List<string> TagIdList { get; set; } = new List<string>();

        public List<int> NGramList { get; set; } = new List<int>();
    }
}
