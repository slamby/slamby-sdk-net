using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentMoveSettings
    {
        /// <summary>
        /// The Id list of the documents you want to move
        /// </summary>
        [Required]
        public IEnumerable<string> Ids { get; set; }

        /// <summary>
        /// The DataSet name where you want to move the selected documents
        /// </summary>
        [Required]
        public string TargetDataSetName { get; set; }
    }
}
