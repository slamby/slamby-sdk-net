using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IMaintenanceManager
    {
        Task<ClientResponse> ChangeSecretAsync(ChangeSecret model);
    }
}