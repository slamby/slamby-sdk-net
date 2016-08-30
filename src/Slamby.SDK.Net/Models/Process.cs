using System;
using System.Collections.Generic;
using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Process
    {
        /// <summary>
        /// The process Guid identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The UTC time of the process start
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// The UTC time of the process end
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// The percent of the whole process. (e.g.: 12.23 means 12.23%)
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Process description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// InProgress - the process is in progress, it's working |
        /// Cancelled - the process was cancelled by the user |
        /// Finished - the process was finished succesffully |
        /// Error - the process stopped by an error, see the ErrorMessages for detailed information |
        /// Interrupted - the process was interrupted by an unknown event (e.g.: server restart) - under development |
        /// Paused - the process was paused  - under development
        /// </summary>
        public ProcessStatusEnum Status { get; set; }

        /// <summary>
        /// Type of the process
        /// </summary>
        public ProcessTypeEnum Type { get; set; }

        public List<string> ErrorMessages { get; set; } = new List<string>();

        public string ResultMessage { get; set; }
    }
}
