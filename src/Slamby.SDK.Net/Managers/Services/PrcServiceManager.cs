using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers.Services
{
    public class PrcServiceManager : BaseManager, IPrcServiceManager
    {
        private static readonly string Endpoint = "api/services/prc";
        private static readonly string PrepareEndpointSuffix = "/prepare";
        private static readonly string ActivateEndpointSuffix = "/activate";
        private static readonly string DeactivateEndpointSuffix = "/deactivate";
        private static readonly string RecommendEndpointSuffix = "/recommend";

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


    }
}
