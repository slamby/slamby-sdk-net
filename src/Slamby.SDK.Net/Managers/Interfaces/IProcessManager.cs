using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IProcessManager
    {
        Task<ClientResponseWithObject<Process>> GetProcessAsync(string processId);

        Task<ClientResponse> CancelProcessAsync(string processId);

        Task<ClientResponseWithObject<IEnumerable<Process>>> GetProcessesAsync(bool allStatus = false);
    }
}
