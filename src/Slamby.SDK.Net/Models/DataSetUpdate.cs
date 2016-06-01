using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// DataSet update object
    /// </summary>
    public class DataSetUpdate
    {
        /// <summary>
        /// Name of your dataset. Contains just A-Z letters and numbers without any space. This field is unique
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
