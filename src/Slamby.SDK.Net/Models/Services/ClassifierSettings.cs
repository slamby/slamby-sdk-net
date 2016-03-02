using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierSettings
    {
        public int NGramCount { get; set; }
        public string DataSetName { get; set; }
        public List<string> TagIds { get; set; }
        public List<string> SampleTagIds { get; set; }
    }
}
