using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentSampleSettings
    {
        [Required]
        public string Id { get; set; }

        public List<string> TagIds { get; set; }

        public bool IsStratified { get; set; }

        [Required]
        public Pagination Pagination { get; set; }

        public double Percent { get; set; }

        public int Size { get; set; }

        public bool IdsOnly { get; set; }
    }
}
