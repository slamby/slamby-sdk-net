using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models
{
    public class Pagination
    {
        /// <summary>
        /// How many element you want to skip. For example if the offset is 6, than the first element will be the 7. in the list
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// How many element you want to get back in this request
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// The ordering of the list, Ascending or Descending
        /// </summary>
        public OrderDirectionEnum OrderDirection { get; set; }

        /// <summary>
        /// It must be an existing field. Declares the base of the ordering
        /// </summary>
        public string OrderByField { get; set; }
    }
}