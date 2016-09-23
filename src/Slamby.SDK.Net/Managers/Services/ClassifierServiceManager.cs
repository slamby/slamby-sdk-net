using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers
{
    public class ClassifierServiceManager : BaseManager, IClassifierServiceManager
    {
        private static readonly string Endpoint = "api/services/classifier";
        private static readonly string PrepareEndpointSuffix = "prepare";
        private static readonly string ActivateEndpointSuffix = "activate";
        private static readonly string DeactivateEndpointSuffix = "deactivate";
        private static readonly string RecommendEndpointSuffix = "recommend";
        private static readonly string ExportDictionariesEndpointSuffix = "exportdictionaries";

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
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, classifierPrepareSettings, $"{serviceId}/{PrepareEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ActivateServiceAsync(string serviceId, ClassifierActivateSettings classifierActivateSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, classifierActivateSettings, $"{serviceId}/{ActivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> DeactivateServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"{serviceId}/{DeactivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<ClassifierRecommendationResult>>> RecommendAsync(string serviceId, ClassifierRecommendationRequest classifierRecommendationRequest)
        {
            return await _client.SendAsync<IEnumerable<ClassifierRecommendationResult>>(System.Net.Http.HttpMethod.Post, classifierRecommendationRequest, $"{serviceId}/{RecommendEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, settings, $"{serviceId}/{ExportDictionariesEndpointSuffix}", null, null);
        }
    }
}
