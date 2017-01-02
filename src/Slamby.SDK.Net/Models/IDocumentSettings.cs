using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models
{
    public interface IDocumentSettings
    {
        List<string> DocumentIdList { get; set; }
        string TargetDataSetName { get; set; }
    }
}
