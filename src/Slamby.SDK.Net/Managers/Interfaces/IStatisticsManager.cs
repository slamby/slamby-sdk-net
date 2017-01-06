using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IStatisticsManager
    {
        Task<ClientResponseWithObject<StatisticsWrapper>> GetStatisticsAsync(int year = -1, int month = -1);
    }
}
