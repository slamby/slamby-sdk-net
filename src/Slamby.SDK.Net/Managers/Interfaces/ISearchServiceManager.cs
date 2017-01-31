using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface ISearchServiceManager
    {
        Task<ClientResponseWithObject<SearchService>> GetServiceAsync(string serviceId);

        Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, SearchPrepareSettings searchPrepareSettings);

        Task<ClientResponseWithObject<Process>> ActivateServiceAsync(string serviceId, SearchActivateSettings searchActivateSettings);

        Task<ClientResponse> DeactivateServiceAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<SearchResultWrapper>>> SearchAsync(string serviceId, SearchRequest searchRequest);
    }
}
