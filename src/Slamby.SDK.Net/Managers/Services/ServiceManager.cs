using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public class ServiceManager : BaseManager, IServiceManager
    {
        private static readonly string Endpoint = "api/services";
        private readonly Dictionary<string, string> Headers = new Dictionary<string, string>();

        public ServiceManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<Service>> CreateServiceAsync(Service service)
        {
            return await _client.SendAsync<Service>(System.Net.Http.HttpMethod.Post, service, null, null, Headers);
        }

        public async Task<ClientResponse> DeleteServiceAsync(string serviceId)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Delete, null, serviceId, null, Headers);
        }

        public async Task<ClientResponseWithObject<Service>> GetServiceAsync(string serviceId)
        {
            return await _client.SendAsync<Service>(System.Net.Http.HttpMethod.Get, null, serviceId, null, Headers);
        }

        public async Task<ClientResponseWithObject<IEnumerable<Service>>> GetServicesAsync()
        {
            return await _client.SendAsync<IEnumerable<Service>>(System.Net.Http.HttpMethod.Get, null, null, null, Headers);
        }

        public async Task<ClientResponse> UpdateServiceAsync(string serviceId, Service service)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Put, service, serviceId, null, Headers);
        }
    }
}
