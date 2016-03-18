﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class TagManager : BaseManager, ITagManager
    {
        private static readonly string Endpoint = "api/tags";
        private static readonly string BulkEndpoint = "api/tags/bulk";
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

        public async Task<ClientResponse> DeleteTagAsync(string tagId, bool force, bool cleanDocuments)
        {
            var queryParameters = new Dictionary<string, string>
            {
                ["force"] = force.ToString(),
                ["cleanDocuments"] = cleanDocuments.ToString()
            };
            return await _client.SendAsync(System.Net.Http.HttpMethod.Delete, null, tagId, queryParameters, Headers);
        }

        public async Task<ClientResponseWithObject<Tag>> GetTagAsync(string tagId, bool withDetails = false)
        {
            var queryParameters = new Dictionary<string, string>
            {
                ["withDetails"] = withDetails.ToString()
            };
            return await _client.SendAsync<Tag>(System.Net.Http.HttpMethod.Get, null, tagId, queryParameters, Headers);
        }

        public async Task<ClientResponseWithObject<IEnumerable<Tag>>> GetTagsAsync(bool withDetails = false)
        {
            var queryParameters = new Dictionary<string, string>
            {
                ["withDetails"] = withDetails.ToString()
            };
            return await _client.SendAsync<IEnumerable<Tag>>(System.Net.Http.HttpMethod.Get, null, null, queryParameters, Headers);
        }

        public async Task<ClientResponse> UpdateTagAsync(string tagId, Tag tag)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Put, tag, tagId, null, Headers);
        }

        public async Task<ClientResponseWithObject<BulkResults>> BulkTagsAsync(TagBulkSettings settings)
        {
            var client = new ApiClient(_configuration, BulkEndpoint);
            return await client.SendAsync<BulkResults>(System.Net.Http.HttpMethod.Post, settings, null, null, Headers);
        }
    }
}
