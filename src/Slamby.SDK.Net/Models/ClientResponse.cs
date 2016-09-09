using System.Net;

namespace Slamby.SDK.Net.Models
{
    public class ClientResponseWithObject<T> : ClientResponse
    {
        /// <summary>
        /// Reponse object
        /// </summary>
        public T ResponseObject { get; set; }
    }

    public class ClientResponse
    {
        /// <summary>
        /// Request was successful or not
        /// </summary>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Response HTTP status code
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// HTTP response reason phrase
        /// </summary>
        public string ServerMessage { get; set; }

        /// <summary>
        /// Error list
        /// </summary>
        public ErrorsModel Errors { get; set; }

        /// <summary>
        /// Server's API version
        /// </summary>
        public string ApiVersion { get; set; }
    }
}
