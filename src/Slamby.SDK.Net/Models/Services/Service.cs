using Slamby.SDK.Net.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class Service
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceStatusEnum? Status { get; set; }
        [Required]
        public ServiceTypeEnum Type { get; set; }

        public List<string> ProcessIdList { get; set; }
        public string ActualProcessId { get; set; }
    }
}
