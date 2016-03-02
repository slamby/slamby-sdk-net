using System.Net;

namespace Slamby.SDK.Net.Models
{
    public class ClientResponseWithObject<T> : ClientResponse
    {
        public T ResponseObject { get; set; }
    }

    public class ClientResponse
    {
        public bool IsSuccessFul { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ServerMessage { get; set; }
        public ErrorsModel Errors { get; set; }
    }
}
