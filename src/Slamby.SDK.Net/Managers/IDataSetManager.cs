using Slamby.SDK.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface IDataSetManager
    {
        Task<ClientResponseWithObject<IEnumerable<DataSet>>> GetDataSetsAsync();
        Task<ClientResponseWithObject<DataSet>> GetDataSetAsync(string dataSetName);
        Task<ClientResponse> CreateDataSetAsync(DataSet dataSet);
        Task<ClientResponse> DeleteDataSetAsync(string dataSetName);
    }
}
