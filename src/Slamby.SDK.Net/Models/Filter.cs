using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class Filter
    {
        /// <summary>
        /// You can direct your search queries into specific tags. 
        /// By giving the required tag id list, the filter will affect just the provided tags. 
        /// It's useful to create powerful search queries inside given tags. 
        /// To filter inside a whole dataset, you can set this field to empty
        /// </summary>
        public List<string> TagIdList { get; set; } = new List<string>();

        /// <summary>
        /// Set here the filters. The value is the query string you want to apply. 
        /// Can be BOOL expressions. You can use these: AND, OR, NOT. 
        /// For example: 'searchforthis AND NOT butnotthis'. 
        /// Also you can use wildcards. For example: 'exampl*'. 
        /// If you want to search in a specified field, than do thie: 'title:searchthisinthetitle'
        /// </summary>
        public string Query { get; set; }
    }
}
