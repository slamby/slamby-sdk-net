using Slamby.SDK.Net.Helpers;
using Slamby.SDK.Net.Models.Enums;
using System.ComponentModel.DataAnnotations;

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
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = 1)]
        public string OrderByField { get; set; }
    }
}
