using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DataSet
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NGramCount { get; set; }
        [Required]
        public string IdField { get; set; }
        [Required]
        public string TagField { get; set; }
        [Required]
        public List<string> InterpretedFields { get; set; }
        public DataSetStats Statistics { get; set; }
        [Required]
        public object SampleDocument { get; set; }
    }
}
