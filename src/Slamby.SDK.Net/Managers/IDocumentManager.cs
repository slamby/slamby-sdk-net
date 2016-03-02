using Slamby.SDK.Net.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public interface IDocumentManager
    {
        Task<ClientResponseWithObject<IEnumerable<object>>> GetDocumentsAsync(string tagId = null);
        Task<ClientResponseWithObject<PaginatedList<object>>> GetSampleDocumentsAsync(DocumentSampleSettings sampleSettings);
        Task<ClientResponseWithObject<PaginatedList<object>>> GetFilteredDocumentsAsync(DocumentFilterSettings filterSettings);

        Task<ClientResponseWithObject<object>> GetDocumentAsync(string documentId);
        Task<ClientResponse> CreateDocumentAsync(object document);
        Task<ClientResponse> UpdateDocumentAsync(string documentId, object document);
        Task<ClientResponse> DeleteDocumentAsync(string documentId);
        Task<ClientResponse> CopyDocumentsToAsync(IEnumerable<string> documentIds, string targetDataSetName);
        Task<ClientResponse> MoveDocumentsToAsync(IEnumerable<string> documentIds, string targetDataSetName);
    }
}
