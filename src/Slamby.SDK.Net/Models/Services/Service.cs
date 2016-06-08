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

        /// <summary>
        /// New - the service was created | 
        /// Busy - the service is working on something (e.g.: during the Prepare) | 
        /// Prepared - the service was prepared so you can activate it to use | 
        /// Active - the service so you can use it
        /// </summary>
        public ServiceStatusEnum? Status { get; set; }
        [Required]
        public ServiceTypeEnum Type { get; set; }

        /// <summary>
        /// Contains all the process ids which belongs to this service
        /// </summary>
        public List<string> ProcessIdList { get; set; }
        public string ActualProcessId { get; set; }
    }
}
