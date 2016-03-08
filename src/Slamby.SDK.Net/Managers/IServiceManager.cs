using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Slamby.SDK.Net.Managers
{
    public interface IServiceManager
    {
        Task<ClientResponse> CreateServiceAsync(Service service);
        Task<ClientResponse> DeleteServiceAsync(string serviceId);
        Task<ClientResponseWithObject<Service>> GetServiceAsync(string serviceId);
        Task<ClientResponseWithObject<IEnumerable<Service>>> GetServicesAsync();
        Task<ClientResponse> UpdateServiceAsync(string serviceId, Service service);
    }
}
