using Slamby.SDK.Net.Models;
using Slamby.SDK.Net.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface IClassifierServiceManager
    {
        Task<ClientResponseWithObject<ClassifierService>> GetServiceAsync(string serviceId);

        Task<ClientResponseWithObject<Process>> PrepareServiceAsync(string serviceId, ClassifierPrepareSettings classifierPrepareSettings);

        Task<ClientResponse> ActivateServiceAsync(string serviceId, ClassifierActivateSettings classifierActivateSettings);

        Task<ClientResponse> DeactivateServiceAsync(string serviceId);

        Task<ClientResponseWithObject<IEnumerable<ClassifierRecommendationResult>>> RecommendServiceAsync(string serviceId, ClassifierRecommendationRequest classifierRecommendationRequest);

        Task<ClientResponseWithObject<Process>> ExportDictionariesAsync(string serviceId, ExportDictionariesSettings settings);
    }
}
