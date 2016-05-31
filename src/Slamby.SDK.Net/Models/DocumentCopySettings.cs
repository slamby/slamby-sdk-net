using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentCopySettings
    {
        /// <summary>
        /// The Id list of the documents you want to copy
        /// </summary>
        [Required]
        public List<string> Ids { get; set; }

        /// <summary>
        /// The DataSet name where you want to copy the selected documents
        /// </summary>
        [Required]
        public string TargetDataSetName { get; set; }
    }
}
