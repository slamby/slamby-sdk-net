using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface ILicenseManager
    {
        Task<ClientResponseWithObject<License>> GetLicenseAsync();
        Task<ClientResponse> SetLicenseAsync(ChangeLicense model);
    }
}