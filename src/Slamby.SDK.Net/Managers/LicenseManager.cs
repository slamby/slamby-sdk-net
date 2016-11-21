using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class LicenseManager : BaseManager, ILicenseManager
    {
        private static readonly string Endpoint = "api/license";

        public LicenseManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<License>> GetLicenseAsync()
        {
            return await _client.SendAsync<License>(System.Net.Http.HttpMethod.Get, null, null, null, null);
        }

        public async Task<ClientResponse> SetLicenseAsync(ChangeLicense model)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Post, model, null, null, null);
        }
    }
}
