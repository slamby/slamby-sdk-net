using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IPrcServiceManager
    {
        Task<ClientResponseWithObject<PrcService>> GetServiceAsync(string serviceId);

        Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, PrcPrepareSettings prcPrepareSettings);

        Task<ClientResponseWithObject<Process>> ActivateServiceAsync(string serviceId, PrcActivateSettings prcActivateSettings);

        Task<ClientResponse> DeactivateServiceAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendAsync(string serviceId, PrcRecommendationRequest prcRecommendationRequest);

        Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings);

        Task<ClientResponseWithObject<IEnumerable<PrcKeywordsResult>>> KeywordsAsync(string serviceId, PrcKeywordsRequest prcKeywordsRequest, bool isStrict);

        Task<ClientResponseWithObject<Process>> IndexAsync(string serviceId, PrcIndexSettings prcIndexSettings);

        Task<ClientResponseWithObject<Process>> IndexPartialAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<PrcRecommendationResult>>> RecommendByIdAsync(string serviceId, PrcRecommendationByIdRequest prcRecommendationRequest);
    }
}
