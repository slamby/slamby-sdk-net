using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IServiceManager
    {
        Task<ClientResponseWithObject<Service>> CreateServiceAsync(Service service);
        Task<ClientResponse> DeleteServiceAsync(string serviceId);
        Task<ClientResponseWithObject<Service>> GetServiceAsync(string serviceId);
        Task<ClientResponseWithObject<IEnumerable<Service>>> GetServicesAsync();
        Task<ClientResponse> UpdateServiceAsync(string serviceId, Service service);
    }
}
