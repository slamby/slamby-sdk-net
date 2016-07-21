using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class HelperManager : BaseManager, IHelperManager
    {
        private static readonly string Endpoint = "api/helper";
        private static readonly string FileParserEndpoint = "api/helper/fileparser";

        public HelperManager(Configuration config) 
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<Status>> FileParserAsync(FileParser fileParser)
        {
            var client = new ApiClient(_configuration, FileParserEndpoint);
            return await client.SendAsync<Status>(System.Net.Http.HttpMethod.Post, fileParser, null, null, null, true);
        }
    }
}
