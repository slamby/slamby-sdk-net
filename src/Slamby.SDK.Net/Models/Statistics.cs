using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Statistics object, describes the usage statistics of a period (month)
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// The month of the actual stastistics. The format is yyyy-MM
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// List of actions
        /// </summary>
        public List<Action> Actions { get; set; }

        /// <summary>
        /// The sum of all requests count in the current period
        /// </summary>
        public int SumOfMonth { get; set; }

        /// <summary>
        /// The sum of all requests of all time
        /// </summary>
        public int Sum { get; set; }
    }

    /// <summary>
    /// An action which is measured by the statistics. Currently it is equivalent with the API endpoints
    /// </summary>
    public class Action
    {
        /// <summary>
        /// The endpoint name with the HTTP method (if there are multiple HTTP methods for an endpoint)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The request count for this action in the current period
        /// </summary>
        public int RequestCount { get; set; }
    }
}
