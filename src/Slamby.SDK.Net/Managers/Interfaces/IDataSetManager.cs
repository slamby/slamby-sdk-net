using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IDataSetManager
    {
        Task<ClientResponseWithObject<IEnumerable<DataSet>>> GetDataSetsAsync();
        Task<ClientResponseWithObject<DataSet>> GetDataSetAsync(string dataSetName);
        Task<ClientResponse> CreateDataSetAsync(DataSet dataSet);
        Task<ClientResponse> CreateDataSetSchemaAsync(DataSet dataSet);
        Task<ClientResponse> DeleteDataSetAsync(string dataSetName);
    }
}
