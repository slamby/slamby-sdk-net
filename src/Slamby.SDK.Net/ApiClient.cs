using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Helpers;
using Newtonsoft.Json.Converters;

namespace Slamby.SDK.Net
{
    public class ApiClient
    {
        private Configuration _configuration { get; set; }
        private string _endpoint { get; set; }

        internal ApiClient(Configuration config, string endpoint)
        {
            _configuration = config;
            _endpoint = endpoint;
        }

        internal async Task<ClientResponse> SendAsync(HttpMethod method, object body, string urlPart, Dictionary<string, string> queryParameters, Dictionary<string, string> headers, bool useGzip = false)
        {
            return await SendAsync<object>(method, body, urlPart, queryParameters, headers, useGzip);
        }

        internal async Task<ClientResponseWithObject<T>> SendAsync<T>(HttpMethod method, object body, string urlPart, Dictionary<string, string> queryParameters, Dictionary<string, string> headers, bool useGzip = false)
        {
            ClientResponseWithObject<T> clientResponse = null;
            var messageHandler = new ApiHttpMessageHandler(useGzip);
            var jsonSerializerSettings = new JsonSerializerSettings();

            jsonSerializerSettings.Converters.Add(new StringEnumConverter());

            using (var client = new HttpClient(messageHandler))
            {
                client.BaseAddress = _configuration.ApiBaseEndpoint;
                client.Timeout = _configuration.Timeout;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation(Constants.AuthorizationHeader, string.Format("{0} {1}", Constants.AuthorizationMethodSlamby, _configuration.ApiSecret));

                if (useGzip)
                {
                    client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
                }

                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                HttpContent content = null;
                if (body != null)
                {
                    var json = JsonConvert.SerializeObject(body, jsonSerializerSettings);
                    content = new StringContent(json, Encoding.UTF8, "application/json");

                    if (useGzip)
                    {
                        content = new CompressedContent(content, "gzip");
                    }
                }
                else
                {
                    content = new ByteArrayContent(new byte[0]);
                }

                HttpResponseMessage responseMsg = null;
                var appendedUri = _appendQueryString(_endpoint, urlPart, queryParameters);

                if (method == HttpMethod.Get)
                {
                    responseMsg = await client.GetAsync(appendedUri);
                }
                else if (method == HttpMethod.Post)
                {
                    responseMsg = await client.PostAsync(appendedUri, content);
                }
                else if (method == HttpMethod.Delete)
                {
                    responseMsg = await client.DeleteAsync(appendedUri);
                }
                else if (method == HttpMethod.Put)
                {
                    responseMsg = await client.PutAsync(appendedUri, content);
                }
                else
                {
                    throw new NotImplementedException();
                }

                clientResponse = new ClientResponseWithObject<T>
                {
                    HttpStatusCode = responseMsg.StatusCode,
                    IsSuccessFul = responseMsg.IsSuccessStatusCode,
                    ServerMessage = responseMsg.ReasonPhrase
                };

                var respString = await responseMsg.Content.ReadAsStringAsync();
                if (responseMsg.IsSuccessStatusCode)
                {
                    if (!string.IsNullOrEmpty(respString))
                    {
                        clientResponse.ResponseObject = JsonConvert.DeserializeObject<T>(respString, jsonSerializerSettings);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(respString))
                    {
                        clientResponse.Errors = JsonConvert.DeserializeObject<ErrorsModel>(respString, jsonSerializerSettings);
                    }
                }

                clientResponse.ApiVersion = responseMsg.Headers.Where(header => string.Equals(header.Key, Constants.ApiVersionHeader, StringComparison.OrdinalIgnoreCase))
                    .SelectMany(header => header.Value)
                    .FirstOrDefault() ?? string.Empty;

                return clientResponse;
            }
        }

        private static string _appendQueryString(string endpoint, string urlPart = null, IDictionary<string, string> queryParamsDic = null)
        {
            var url = endpoint;
            if (urlPart != null)
            {
                url = string.Format("{0}/{1}", url, urlPart);
            }
            if (queryParamsDic != null)
            {
                url = string.Format("{0}?{1}", url, string.Join("&", queryParamsDic.Select((x) => x.Key + "=" + x.Value)));
            }
            return url;
        }
    }
}
