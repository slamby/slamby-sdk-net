using Slamby.SDK.Net.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers
{
    public class SearchServiceManager : BaseManager, ISearchServiceManager
    {
        private static readonly string Endpoint = "api/services/search";
        private static readonly string PrepareEndpointSuffix = "prepare";
        private static readonly string ActivateEndpointSuffix = "activate";
        private static readonly string DeactivateEndpointSuffix = "deactivate";
        public SearchServiceManager(Configuration config)
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<SearchService>> GetServiceAsync(string serviceId)
        {
            return await _client.SendAsync<SearchService>(System.Net.Http.HttpMethod.Get, null, serviceId, null, null);
        }

        public async Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, SearchPrepareSettings searchPrepareSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, searchPrepareSettings, $"{serviceId}/{PrepareEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<Process>> ActivateServiceAsync(string serviceId, SearchActivateSettings searchActivateSettings)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, searchActivateSettings, $"{serviceId}/{ActivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponse> DeactivateServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"{serviceId}/{DeactivateEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<SearchResultWrapper>>> SearchAsync(string serviceId, SearchRequest searchRequest)
        {
            return await _client.SendAsync<IEnumerable<SearchResultWrapper>>(System.Net.Http.HttpMethod.Post, searchRequest, $"{serviceId}", null, null);
        }
    }
}
