using System;

namespace Slamby.SDK.Net
{
    public class Configuration
    {
        private Uri apiBaseEndpoint;

        public Uri ApiBaseEndpoint
        {
            get
            {
                return apiBaseEndpoint;
            }

            set
            {
                // make sure ends with "/"
                if (!value.OriginalString.EndsWith("/"))
                {
                    apiBaseEndpoint = new Uri(value.OriginalString + "/");
                }
                else
                {
                    apiBaseEndpoint = value;
                }
            }
        }

        public string ApiSecret { get; set; }

        public TimeSpan Timeout { get; set; } = new TimeSpan(0, 5, 0);

        public int ParallelLimit { get; set; }
    }   
}