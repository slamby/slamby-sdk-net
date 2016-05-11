using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class StatusManager : BaseManager, IStatusManager
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
