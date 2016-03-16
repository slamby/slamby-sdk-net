using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public class ClassifierServiceManager : BaseManager, IClassifierServiceManager
    {
        private static readonly string Endpoint = "api/services/classifier";
        private static readonly string PrepareEndpointSuffix = "/prepare";
        private static readonly string ActivateEndpointSuffix = "/activate";
        private static readonly string DeactivateEndpointSuffix = "/deactivate";
        private static readonly string RecommendEndpointSuffix = "/recommend";

        public ClassifierServiceManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<ClassifierService>> GetServiceAsync(string serviceId)
        {
            return await _client.SendAsync<ClassifierService>(System.Net.Http.HttpMethod.Get, null, serviceId, null, null);
        }

        public async Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, ClassifierPrepareSettings classifierPrepareSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, classifierPrepareSettings, $"serviceId/{PrepareEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> ActivateServiceAsync(string serviceId, ClassifierActivateSettings classifierActivateSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, classifierActivateSettings, $"serviceId/{ActivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> DeactivateServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"serviceId/{DeactivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<ClassifierRecommendationResult>> RecommendServiceAsync(string serviceId, ClassifierRecommendationRequest classifierRecommendationRequest)
        {
            return await _client.SendAsync<ClassifierRecommendationResult>(System.Net.Http.HttpMethod.Post, classifierRecommendationRequest, $"serviceId/{RecommendEndpointSuffix}", null, null);
        }
    }
}
