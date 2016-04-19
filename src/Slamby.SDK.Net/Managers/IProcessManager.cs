using Slamby.SDK.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface IProcessManager
    {
        Task<ClientResponseWithObject<Process>> GetProcessAsync(string processId);

        Task<ClientResponse> CancelProcessAsync(string processId);

        Task<ClientResponseWithObject<IEnumerable<Process>>> GetProcessesAsync(bool allStatus = false);
    }
}
