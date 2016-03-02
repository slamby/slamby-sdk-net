using Slamby.SDK.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface ITagManager
    {
        Task<ClientResponseWithObject<IEnumerable<Tag>>> GetTagsAsync(string parentId = null, int? level = null);
        Task<ClientResponseWithObject<Tag>> GetTagAsync(string tagId);
        Task<ClientResponse> CreateTagAsync(Tag tag);
        Task<ClientResponse> UpdateTagAsync(string tagId, Tag tag);
        Task<ClientResponse> DeleteTagAsync(string tagId);
    }
}
