using Slamby.SDK.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return await _client.SendAsync<Process>(System.Net.Http.HttpMethod.Post, null, $"processId/{CancelEndpointSuffix}", null, null);
        }
    }
}
