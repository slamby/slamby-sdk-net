using Slamby.SDK.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface ITagManager
    {
        Task<ClientResponseWithObject<IEnumerable<Tag>>> GetTagsAsync(bool withDetails = false);
        Task<ClientResponseWithObject<Tag>> GetTagAsync(string tagId, bool withDetails = false);
        Task<ClientResponseWithObject<Tag>> CreateTagAsync(Tag tag);
        Task<ClientResponse> UpdateTagAsync(string tagId, Tag tag);
        Task<ClientResponse> DeleteTagAsync(string tagId, bool force, bool cleanDocuments);
        Task<ClientResponseWithObject<Process>> WordsExportAsync(TagsExportWordsSettings settings);
    }
}
