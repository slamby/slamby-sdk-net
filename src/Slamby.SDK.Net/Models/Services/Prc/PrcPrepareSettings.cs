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

        public List<string> TagIdList { get; set; }

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
