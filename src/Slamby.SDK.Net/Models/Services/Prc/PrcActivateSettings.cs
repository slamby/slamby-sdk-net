using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcActivateSettings
    {
        /// <summary>
        /// The PRC Service will use these fields for the recommendation. The default is the interpreted fields of the destination dataset
        /// </summary>
        public List<string> FieldsForRecommendation { get; set; } = new List<string>();
        
        /// <summary>
        /// The name of the DataSet in which this PRC service will search for the similar documents. The default is the source dataset (which was used during the preparation)
        /// </summary>
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string DestinationDataSetName { get; set; }
    }
}
