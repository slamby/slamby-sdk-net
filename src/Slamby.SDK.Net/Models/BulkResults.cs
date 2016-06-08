using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class BulkResults
    {
        /// <summary>
        /// Array of the documents to be saved
        /// </summary>
        public List<BulkResult> Results { get; set; }

        public BulkResults()
        {
            Results = new List<BulkResult>();
        }
    }
}
