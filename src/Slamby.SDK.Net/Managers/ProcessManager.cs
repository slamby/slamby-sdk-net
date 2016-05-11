using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class ProcessManager : BaseManager, IProcessManager
    {
        private static readonly string Endpoint = "api/processes";
        private static readonly string CancelEndpointSuffix = "/cancel";

        public ProcessManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<Process>> GetProcessAsync(string processId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Get, null, processId, null, null);
        }

        public async Task<ClientResponse> CancelProcessAsync(string processId)
        {
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"{processId}/{CancelEndpointSuffix}", null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<Process>>> GetProcessesAsync(bool allStatus = false)
        {
            var queryParameters = new Dictionary<string, string>
            {
                ["allStatus"] = allStatus.ToString()
            };
            return await _client.SendAsync<IEnumerable<Process>>(System.Net.Http.HttpMethod.Get, null, null, queryParameters, null);
        }
    }
}
