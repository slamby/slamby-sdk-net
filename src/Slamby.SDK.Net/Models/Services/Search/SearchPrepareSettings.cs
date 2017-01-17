using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class SearchPrepareSettings
    {
        [Required]
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string DataSetName { get; set; }
    }
}
