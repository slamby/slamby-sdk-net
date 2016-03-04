using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models
{
    public class Pagination
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public OrderDirectionEnum OrderDirection { get; set; }
        public string OrderByField { get; set; }
    }
}