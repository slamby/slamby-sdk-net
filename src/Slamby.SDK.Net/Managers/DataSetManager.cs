using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class DataSetManager : BaseManager, IDataSetManager
    {
        private static readonly string Endpoint = "api/datasets";
        private static readonly string SchemaEndpoint = "api/datasets/schema";

        public DataSetManager(Configuration config) : base(config, Endpoint) { }

        public async Task<ClientResponse> CreateDataSetAsync(DataSet dataSet)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Post, dataSet, null, null, null);
        }

        public async Task<ClientResponse> CreateDataSetSchemaAsync(DataSet dataSet)
        {
            var client = new ApiClient(_configuration, SchemaEndpoint);
            return await client.SendAsync(System.Net.Http.HttpMethod.Post, dataSet, null, null, null);
        }

        public async Task<ClientResponse> DeleteDataSetAsync(string dataSetName)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Delete, null, dataSetName, null, null);
        }

        public async Task<ClientResponseWithObject<DataSet>> GetDataSetAsync(string dataSetName)
        {
            return await _client.SendAsync<DataSet>(System.Net.Http.HttpMethod.Get, null, dataSetName, null, null);
        }

        public async Task<ClientResponseWithObject<IEnumerable<DataSet>>> GetDataSetsAsync()
        {
            return await _client.SendAsync<IEnumerable<DataSet>>(System.Net.Http.HttpMethod.Get, null, null, null, null);
        }

        public async Task<ClientResponse> UpdateDataSetAsync(string dataSetName, DataSetUpdate dataSetUpdate)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Put, dataSetUpdate, dataSetName, null, null);
        }
    }
}
