using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface IPrcServiceManager
    {
        Task<ClientResponseWithObject<PrcService>> GetServiceAsync(string serviceId);

        Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, PrcPrepareSettings prcPrepareSettings);

        Task<ClientResponse> ActivateServiceAsync(string serviceId, PrcActivateSettings prcActivateSettings);

        Task<ClientResponse> DeactivateServiceAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendServiceAsync(string serviceId, PrcRecommendationRequest prcRecommendationRequest);

        Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings);
    }
}
