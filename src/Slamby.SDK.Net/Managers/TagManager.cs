using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class TagManager : BaseManager, ITagManager
    {
        private static readonly string Endpoint = "api/tags";
        private readonly Dictionary<string, string> Headers = new Dictionary<string, string>();

        public TagManager(Configuration config, string dataSetName) : 
            base(config, Endpoint)
        {
            Headers.Add(Constants.DataSetHeader, dataSetName);
        }

        public async Task<ClientResponse> CreateTagAsync(Tag tag)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Post, tag, null, null, Headers);
        }

        public async Task<ClientResponse> DeleteTagAsync(string tagId)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Delete, null, tagId, null, Headers);
        }

        public async Task<ClientResponseWithObject<Tag>> GetTagAsync(string tagId)
        {
            return await _client.SendAsync<Tag>(System.Net.Http.HttpMethod.Get, null, tagId, null, Headers);
        }

        public async Task<ClientResponseWithObject<IEnumerable<Tag>>> GetTagsAsync(string parentId = null, int? level = default(int?))
        {
            return await _client.SendAsync<IEnumerable<Tag>>(System.Net.Http.HttpMethod.Get, null, null, null, Headers);
        }

        public async Task<ClientResponse> UpdateTagAsync(string tagId, Tag tag)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Put, tag, tagId, null, Headers);
        }
    }
}
