using System.Collections.Generic;

namespace Slamby.SDK.Net.Models.Services
{
    /// <summary>
    /// These settings are required for the recommendation (Recommend method)
    /// </summary>
    public class ClassifierActivateSettings : ServiceActivateSettings
    {
        /// <summary>
        /// The list of the tag Ids which will emphasized during the recommendation
        /// </summary>
        public List<string> EmphasizedTagIdList { get; set; } = new List<string>();

        /// <summary>
        /// "The list of the tag Ids which will be activated (the recommendation will be contains these only)
        /// </summary>
        public List<string> TagIdList { get; set; } = new List<string>();

        /// <summary>
        /// The list of the NGrams will be activated (the recommendation algorithm will be use these only)
        /// </summary>
        public List<int> NGramList { get; set; } = new List<int>();
    }
}
