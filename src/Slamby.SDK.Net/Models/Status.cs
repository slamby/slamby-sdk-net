namespace Slamby.SDK.Net.Models
{
    public class Status
    {
        public int ProcessorCount { get; set; }

        public decimal AvailableFreeSpace { get; set; }

        public string ApiVersion { get; set; }

        public decimal CpuUsage { get; internal set; }

        public decimal TotalMemory { get; internal set; }

        public decimal FreeMemory { get; internal set; }
    }
}
