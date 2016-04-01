using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Helpers
{
    public static class HttpMessageHelper
    {
        public static string Format(this HttpRequestMessage request, string requestId)
        {
            var content = string.Empty;

            if (request.Content != null)
            {
                content = Task.Run(async () =>
                    {
                        var httpContent = request.Content is CompressedContent
                            ? (request.Content as CompressedContent).OriginalContent
                            : request.Content;

                        return await httpContent.ReadAsStringAsync();
                    }
                ).Result;
            }
                
            var requestString = string.Format(
                "REQUEST #{4}\n" +
                "----------------------\n" +
                "{0} {1}\n" +
                "Headers:\n{2}\n\n" +
                "Content:  \n{3}\n\n",
                request.Method.Method, request.RequestUri.AbsoluteUri,
                string.Join("\n", request.Headers.Select(h => string.Format(h.Key + "|" + string.Join(" ", h.Value)))),
                content,
                requestId);

            return requestString;
        }

        public static string Format(this HttpResponseMessage response, string requestId)
        {
            var content = Task.Run(async () => response.Content != null ? await response.Content.ReadAsStringAsync() : string.Empty).Result;
            var responseString = string.Format(
                "RESPONSE #{4}\n" +
                "----------------------\n" +
                "{0} {1}\n" +
                "Headers: \n{2}\n\n" +
                "Content: \n{3}\n\n",
                (int)response.StatusCode, response.ReasonPhrase,
                string.Join("\n", response.Headers.Select(h => string.Format(h.Key + "|" + string.Join(" ", h.Value)))),
                content, 
                requestId);

            return responseString;
        }
    }
}
