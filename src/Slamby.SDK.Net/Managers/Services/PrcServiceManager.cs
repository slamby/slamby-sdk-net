using System.Collections.Generic;
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

        public PrcServiceManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<PrcService>> GetServiceAsync(string serviceId)
        {
            return await _client.SendAsync<PrcService>(System.Net.Http.HttpMethod.Get, null, serviceId, null, null);
        }

        public async Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, PrcPrepareSettings prcPrepareSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, prcPrepareSettings, $"{serviceId}/{PrepareEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> ActivateServiceAsync(string serviceId, PrcActivateSettings prcActivateSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, prcActivateSettings, $"{serviceId}/{ActivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> DeactivateServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"{serviceId}/{DeactivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendServiceAsync(string serviceId, PrcRecommendationRequest prcRecommendationRequest)
        {
            return await _client.SendAsync<IEnumerable<PrcRecommendationResult>>(System.Net.Http.HttpMethod.Post, prcRecommendationRequest, $"{serviceId}/{RecommendEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, settings, $"{serviceId}/{ExportDictionariesEndpointSuffix}", null, null);
        }
    }
}
