using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IClassifierServiceManager
    {
        Task<ClientResponseWithObject<ClassifierService>> GetServiceAsync(string serviceId);

        Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, ClassifierPrepareSettings classifierPrepareSettings);

        Task<ClientResponse> ActivateServiceAsync(string serviceId, ClassifierActivateSettings classifierActivateSettings);

        Task<ClientResponse> DeactivateServiceAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<ClassifierRecommendationResult>>> RecommendAsync(string serviceId, ClassifierRecommendationRequest classifierRecommendationRequest);

        Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings);
    }
}
