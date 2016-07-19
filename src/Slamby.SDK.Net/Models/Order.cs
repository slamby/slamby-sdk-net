using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models
{
    public class Order
    {
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
