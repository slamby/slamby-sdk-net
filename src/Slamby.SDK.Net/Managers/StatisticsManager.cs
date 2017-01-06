using Slamby.SDK.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Managers
{
    public class StatisticsManager : BaseManager
    {
        private static readonly string Endpoint = "api/statistics";

        public StatisticsManager(Configuration config)
            : base(config, Endpoint)
        {
            _configuration = config;
        }

        public async Task<ClientResponseWithObject<StatisticsWrapper>> GetStatisticsAsync(int year = -1, int month = -1)
        {
            return await _client.SendAsync<StatisticsWrapper>(System.Net.Http.HttpMethod.Get, null, $"{year}/{month}", null, null);
        }
    }
}
