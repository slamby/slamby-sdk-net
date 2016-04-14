using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services.Classifier
{
    public class ClassifierExportDictionariesSettings
    {
        public List<string> TagIdList { get; set; }
        public List<int> NGramList { get; set; }
    }
}
