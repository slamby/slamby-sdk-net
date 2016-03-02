using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class PaginatedList<T>
    {
        public IEnumerable<T> Items { get; set; }
        public Pagination Pagination { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
