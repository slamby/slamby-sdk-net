using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Helpers
{
    public class ApiHttpMessageHandler : DelegatingHandler
    {
        private static Random rnd = new Random();

        private string requestId;

        private bool useMessagePublisher;

        public ApiHttpMessageHandler(bool useGzip, bool useMessagePublisher)
        {
            this.useMessagePublisher = useMessagePublisher;
            InnerHandler = new HttpClientHandler()
            {
                AutomaticDecompression = useGzip
                    ? System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
                    : System.Net.DecompressionMethods.None
            };
            requestId = string.Format("{0}{1}", DateTime.Now.Ticks, rnd.Next(0, 100000));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            if (useMessagePublisher) RawMessagePublisher.Instance.Publish(request.Format(requestId));
            var response = await base.SendAsync(request, cancellationToken);
            if (useMessagePublisher) RawMessagePublisher.Instance.Publish(response.Format(requestId));

            return response;
        }
    }
}
