using System;

namespace Slamby.SDK.Net
{
    public class Configuration
    {
        public Uri ApiBaseEndpoint { get; set; }

        public string ApiSecret { get; set; }

        public TimeSpan Timeout { get; set; } = new TimeSpan(0, 5, 0);

        public int ParallelLimit { get; set; }
    }   
}