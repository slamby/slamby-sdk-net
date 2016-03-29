using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcService : Service
    {
        public PrcPrepareSettings PrepareSettings { get; set; }

        public PrcActivateSettings ActivateSettings { get; set; }
    }
}
