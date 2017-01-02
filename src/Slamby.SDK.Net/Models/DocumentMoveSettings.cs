using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentMoveSettings : IDocumentSettings
    {
        /// <summary>
        /// The Id list of the documents you want to move
        /// </summary>
        [Required]
        public List<string> DocumentIdList { get; set; } = new List<string>();

        /// <summary>
        /// The DataSet name where you want to move the selected documents
        /// </summary>
        [Required]
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string TargetDataSetName { get; set; }
    }
}
