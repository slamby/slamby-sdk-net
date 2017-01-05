namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Status object
    /// </summary>
    public class Status
    {
        /// <summary>
        /// API version string
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Number of processors on the API machine
        /// </summary>
        /// <value>
        /// If the current machine contains multiple processor
        /// groups, this property returns the number of logical processors that are available
        /// for use by the common language runtime (CLR).
        /// </value>
        public int ProcessorCount { get; set; }

        /// <summary>
        /// CPU usage %
        /// </summary>
        public decimal CpuUsage { get; set; }

        /// <summary>
        /// Available free disk space in MB
        /// </summary>
        public decimal AvailableFreeSpace { get; set; }

        /// <summary>
        /// Total disk space in MB
        /// </summary>
        public decimal TotalSpace { get; set; }

        /// <summary>
        /// Total physical memory in MB
        /// </summary>
        public decimal TotalMemory { get; set; }

        /// <summary>
        /// Free physical memory in MB
        /// </summary>
        public decimal FreeMemory { get; set; }
    }
}
