using System;

namespace Slamby.SDK.Net.Tests
{
    public static class TestHelper
    {
        public static Configuration GetConfiguration()
        {
            return new Configuration()
                {
                    ApiBaseEndpoint = new Uri("http://localhost:29689"),
                    ApiSecret = ""
                };
        }
    }
}
