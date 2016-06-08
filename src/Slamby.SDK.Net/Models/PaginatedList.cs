using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class PaginatedList<T>
    {
        /// <summary>
        /// Containing the actual displayed items. The type of the elements depend on the method
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Pagination object
        /// </summary>
        public Pagination Pagination { get; set; }

        /// <summary>
        /// The count of the actual returned items
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The count of all items which are the pagination applied
        /// </summary>
        public int Total { get; set; }
    }
}
