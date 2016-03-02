using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models.Services
{
    public class ClassifierService : Service
    {
        public ClassifierSettings Settings { get; set; }
        public ClassifierStatusEnum Status { get; set; }
    }
}
