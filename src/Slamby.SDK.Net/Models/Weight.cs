namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Weight object
    /// </summary>
    public class Weight
    {
        /// <summary>
        /// Set here the filters. The value is the query string you want to apply. 
        /// Can be BOOL expressions. You can use these: AND, OR, NOT. 
        /// For example: 'searchforthis AND NOT butnotthis'. 
        /// Also you can use wildcards. For example: 'exampl*'. 
        /// If you want to search in a specified field, than do this: 'title:searchthisinthetitle'
        /// </summary>
        public string Query { get; set; }


        public double Value { get; set; }
    }
}
