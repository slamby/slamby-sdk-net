using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models
{
    public class DocumentCopySettings
    {
        [Required]
        public List<string> Ids { get; set; }
        [Required]
        public string TargetDataSetName { get; set; }
    }
}
