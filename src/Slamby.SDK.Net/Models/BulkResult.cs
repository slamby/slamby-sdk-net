namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// "Result of a bulk save element.
    /// If the save was successful then the StatusCode is 2XX. 
    /// If there was a problem, the StatusCode is not 2XX, and the error message is in the Error field.
    /// </summary>
    public class BulkResult
    {
        /// <summary>
        /// HTTP status code
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Document id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Error { get; set; }

        public static BulkResult Create(string id, int statusCode, string error)
        {
            return new BulkResult()
            {
                StatusCode = statusCode,
                Id = id,
                Error = error
            };
        }
    }
}
