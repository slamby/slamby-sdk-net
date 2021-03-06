﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Slamby.SDK.Net.Managers.Interfaces;
using Slamby.SDK.Net.Models;

namespace Slamby.SDK.Net.Managers
{
    public class DocumentManager : BaseManager, IDocumentManager
    {
        private static readonly string Endpoint = "api/documents";
        private static readonly string FilterEndpoint = $"{Endpoint}/filter";
        private static readonly string SampleEndpoint = $"{Endpoint}/sample";
        private static readonly string CopyEndpoint = $"{Endpoint}/copy";
        private static readonly string MoveEndpoint = $"{Endpoint}/move";
        private static readonly string BulkEndpoint = $"{Endpoint}/bulk";
        private readonly Dictionary<string, string> Headers = new Dictionary<string, string>();

        public DocumentManager(Configuration config, string dataSetName) : base(config, Endpoint)
        {
            Headers.Add(Constants.DataSetHeader, dataSetName);
        }

        public async Task<ClientResponse> CopyDocumentsToAsync(DocumentCopySettings settings)
        {
            var client = new ApiClient(_configuration, CopyEndpoint);
            return await client.SendAsync(System.Net.Http.HttpMethod.Post, settings, null, null, Headers);
        }

        public async Task<ClientResponse> CreateDocumentAsync(object document)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Post, document, null, null, Headers);
        }

        public async Task<ClientResponse> DeleteDocumentAsync(string documentId)
        {
            return await _client.SendAsync(System.Net.Http.HttpMethod.Delete, null, documentId, null, Headers);
        }

        public async Task<ClientResponseWithObject<object>> GetDocumentAsync(string documentId)
        {
            return await _client.SendAsync<object>(System.Net.Http.HttpMethod.Get, null, documentId, null, Headers);
        }

        public async Task<ClientResponseWithObject<PaginatedList<object>>> GetSampleDocumentsAsync(DocumentSampleSettings sampleSettings)
        {
            var client = new ApiClient(_configuration, SampleEndpoint);
            return await client.SendAsync<PaginatedList<object>>(System.Net.Http.HttpMethod.Post, sampleSettings, null, null, Headers, true);
        }

        public async Task<ClientResponseWithObject<PaginatedList<object>>> GetFilteredDocumentsAsync(DocumentFilterSettings filterSettings, string scrollId)
        {
            var client = new ApiClient(_configuration, FilterEndpoint);

            if (!string.IsNullOrEmpty(scrollId))
            {
                return await client.SendAsync<PaginatedList<object>>(System.Net.Http.HttpMethod.Post, null, scrollId, null, Headers, false);
            }

            return await client.SendAsync<PaginatedList<object>>(System.Net.Http.HttpMethod.Post, filterSettings, null, null, Headers, true);
        }

        public async Task<ClientResponse> MoveDocumentsToAsync(DocumentMoveSettings settings)
        {
            var client = new ApiClient(_configuration, MoveEndpoint);
            return await client.SendAsync(System.Net.Http.HttpMethod.Post, settings, null, null, Headers);
        }

        public async Task<ClientResponseWithObject<object>> UpdateDocumentAsync(string documentId, object document)
        {
            return await _client.SendAsync<object>(System.Net.Http.HttpMethod.Put, document, documentId, null, Headers);
        }

        public async Task<ClientResponseWithObject<BulkResults>> BulkDocumentsAsync(DocumentBulkSettings settings)
        {
            var client = new ApiClient(_configuration, BulkEndpoint);
            return await client.SendAsync<BulkResults>(System.Net.Http.HttpMethod.Post, settings, null, null, Headers, true);
        }
    }
}
