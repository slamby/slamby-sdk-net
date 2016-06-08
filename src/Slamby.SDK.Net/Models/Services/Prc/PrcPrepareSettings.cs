using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcPrepareSettings
    {
        [Required]
        public string DataSetName { get; set; }

        public List<string> TagIdList { get; set; }
    }
}
