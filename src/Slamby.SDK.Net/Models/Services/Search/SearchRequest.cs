using System.Linq;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchRequest
    {
        public string Text { get; set; }

        public int Count { get; set; }

        public HighlightSettings HighlightSettings { get; set; }

        public AutoCompleteSettings AutoCompleteSettings { get; set; }

        public SearchSettings SearchSettings { get; set; }

        public ClassifierSettings ClassifierSettings { get; set; }

    }
}
