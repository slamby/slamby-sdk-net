namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// File Parser result object
    /// </summary>
    public class FileParserResult
    {
        /// <summary>
        /// The text content of sent document. Can be empty.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The title of the document. Can be null or empty.
        /// </summary>
        public string Title { get; set; }

        public string Date { get; set; }

        /// <summary>
        /// The author of the document. Can be null or empty.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Keywords of the document. Can be null or empty.
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// The type of the document (e.g.: application/pdf). Can be empty.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// The length of the received document.
        /// </summary>
        public int ContentLength { get; set; }

        /// <summary>
        /// Detected language of the document (e.g.: en). Can be empty.
        /// </summary>
        public string Language { get; set; }
    }
}
