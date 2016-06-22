using System.Threading.Tasks;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers.Interfaces
{
    public interface IDocumentManager
    {
        Task<ClientResponseWithObject<PaginatedList<object>>> GetSampleDocumentsAsync(DocumentSampleSettings sampleSettings);
        Task<ClientResponseWithObject<PaginatedList<object>>> GetFilteredDocumentsAsync(DocumentFilterSettings filterSettings);

        Task<ClientResponseWithObject<object>> GetDocumentAsync(string documentId, DocumentGetSettings getSettings);
        Task<ClientResponse> CreateDocumentAsync(object document);
        Task<ClientResponse> UpdateDocumentAsync(string documentId, object document);
        Task<ClientResponse> DeleteDocumentAsync(string documentId);
        Task<ClientResponse> CopyDocumentsToAsync(DocumentCopySettings settings);
        Task<ClientResponse> MoveDocumentsToAsync(DocumentMoveSettings settings);
    }
}
