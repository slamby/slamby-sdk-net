namespace Slamby.SDK.Net.Models
{
    public class BulkResult
    {
        public int StatusCode { get; set; }

        public string Id { get; set; }

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
