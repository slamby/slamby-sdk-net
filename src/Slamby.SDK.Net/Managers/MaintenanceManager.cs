using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class MaintenanceManager : BaseManager, IMaintenanceManager
    {
        private static readonly string Endpoint = "api/maintenance";
        private static readonly string ChangeSecretEndpoint = $"{Endpoint}/ChangeSecret";

        public MaintenanceManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponse> ChangeSecretAsync(ChangeSecret model)
        {
            var client = new ApiClient(_configuration, ChangeSecretEndpoint);
            return await client.SendAsync(System.Net.Http.HttpMethod.Post, model, null, null, null);
        }
    }
}
