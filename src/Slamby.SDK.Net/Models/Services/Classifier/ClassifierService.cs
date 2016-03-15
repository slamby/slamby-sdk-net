using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierService : Service
    {
        public ClassifierPrepareSettings PrepareSettings { get; set; }

        public ClassifierActivateSettings ActivateSettings { get; set; }
    }
}
