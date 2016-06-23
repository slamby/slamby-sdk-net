namespace Slamby.SDK.Net.Models
{
    public class Pagination
    {
        /// <summary>
        /// Identifier for the next series of items
        /// </summary>
        public string ScrollId { get; set; }

        /// <summary>
        /// How many element you want to get back in this request
        /// </summary>
        public int Limit { get; set; }
    }
}