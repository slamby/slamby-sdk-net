using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// DataSet update object
    /// </summary>
    public class DataSetUpdate
    {
        /// <summary>
        /// Name of your dataset. Can contains just A-Z letters, numbers, _ (underscore) and - (hyphen) without any space. This field is unique
        /// </summary>
        [Required]
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string Name { get; set; }
    }
}
