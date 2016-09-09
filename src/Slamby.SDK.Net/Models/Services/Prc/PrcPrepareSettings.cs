using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcPrepareSettings
    {
        [Required]
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string DataSetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> TagIdList { get; set; } = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        [Range(0, 2)]
        public int CompressLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CompressSettings CompressSettings { get; set; }

    }
}
