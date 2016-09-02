using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers
{
    public class PrcServiceManager : BaseManager, IPrcServiceManager
    {
        private static readonly string Endpoint = "api/services/prc";
        private static readonly string PrepareEndpointSuffix = "/prepare";
        private static readonly string ActivateEndpointSuffix = "/activate";
        private static readonly string DeactivateEndpointSuffix = "/deactivate";
        private static readonly string RecommendEndpointSuffix = "/recommend";
        private static readonly string ExportDictionariesEndpointSuffix = "/exportdictionaries";
        private static readonly string KeywordsEndpointSuffix = "/keywords";
        private static readonly string IndexEndpointSuffix = "/index";
        private static readonly string IndexPartialEndpointSuffix = "/indexpartial";
        private static readonly string RecommendByIdEndpointSuffix = "/recommendbyid";

        public PrcServiceManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<PrcService>> GetServiceAsync(string serviceId)
        {
            return await _client.SendAsync<PrcService>(HttpMethod.Get, null, serviceId, null, null);
        }

        public async Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, PrcPrepareSettings prcPrepareSettings)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, prcPrepareSettings, $"{serviceId}/{PrepareEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ActivateServiceAsync(string serviceId, PrcActivateSettings prcActivateSettings)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, prcActivateSettings, $"{serviceId}/{ActivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> DeactivateServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, null, $"{serviceId}/{DeactivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendAsync(string serviceId, PrcRecommendationRequest prcRecommendationRequest)
        {
            return await _client.SendAsync<IEnumerable<PrcRecommendationResult>>(HttpMethod.Post, prcRecommendationRequest, $"{serviceId}/{RecommendEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, settings, $"{serviceId}/{ExportDictionariesEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<PrcKeywordsResult>>> KeywordsAsync(string serviceId, PrcKeywordsRequest prcKeywordsRequest, bool isStrict = false)
        {
            var queryParameters = new Dictionary<string, string>
            {
                ["isStrict"] = isStrict.ToString(),
            };
            return await _client.SendAsync<IEnumerable<PrcKeywordsResult>>(HttpMethod.Post, prcKeywordsRequest, $"{serviceId}/{KeywordsEndpointSuffix}", queryParameters, null);
        }

        public async Task<ClientResponseWithObject<Process>> IndexAsync(string serviceId, PrcIndexSettings prcIndexSettings)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, prcIndexSettings, $"{serviceId}/{IndexEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> IndexPartialAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(HttpMethod.Post, null, $"{serviceId}/{IndexPartialEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendByIdAsync(string serviceId, PrcRecommendationByIdRequest prcRecommendationRequest)
        {
            return await _client.SendAsync<IEnumerable<PrcRecommendationResult>>(HttpMethod.Post, prcRecommendationRequest, $"{serviceId}/{RecommendByIdEndpointSuffix}", null, null);
        }
    }
}
