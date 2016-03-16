using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class BulkResults
    {
        public List<BulkResult> Results { get; private set; }

        public BulkResults()
        {
            Results = new List<BulkResult>();
        }
    }
}
