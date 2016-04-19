using Slamby.SDK.Net.Models;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public class StatusManager : BaseManager
    {
        private static readonly string Endpoint = "api/status";

        public StatusManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<Status>> GetStatusAsync()
        {
            return await _client.SendAsync<Status>(System.Net.Http.HttpMethod.Get, null, null, null, null);
        }
    }
}
