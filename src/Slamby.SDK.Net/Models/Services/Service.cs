using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Slamby.SDK.Net.Models.Enums;

namespace Slamby.SDK.Net.Models.Services
{
    public class Service
    {
        /// <summary>
        /// Service unique identifier. It cannot be modified.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User-defined name for the service
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Alias name of the service. Services can be accessed via this name.
        /// Alias can be modified. It is unique amongst the services.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Service description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// New - the service was created | 
        /// Busy - the service is working on something (e.g.: during the Prepare) | 
        /// Prepared - the service was prepared so you can activate it to use | 
        /// Active - the service so you can use it
        /// </summary>
        public ServiceStatusEnum? Status { get; set; }

        /// <summary>
        /// Type of the service.
        /// Currently supported types:
        /// - Classifier
        /// - Prc
        /// </summary>
        [Required]
        public ServiceTypeEnum Type { get; set; }

        /// <summary>
        /// Contains all the process ids which belong to this service
        /// </summary>
        public List<string> ProcessIdList { get; set; } = new List<string>();

        public string ActualProcessId { get; set; }
    }
}
