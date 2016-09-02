using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IHelperManager
    {
        Task<ClientResponseWithObject<Status>> FileParserAsync(FileParser fileParser);
    }
}