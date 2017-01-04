using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcKeywordsRequest
    {
        /// <summary>
        /// The text which you want to extract the keywords from
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// The extracting keywords calculation depends on this Tag. Prc Service try to detect it automatically if it's not provided
        /// </summary>
        public string TagId { get; set; }
    }
}
