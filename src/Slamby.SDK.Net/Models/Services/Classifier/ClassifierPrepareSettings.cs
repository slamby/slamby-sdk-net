﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    /// <summary>
    /// These settings are required for the training (Prepare method)
    /// </summary>
    public class ClassifierPrepareSettings : ServicePrepareSettings
    {
        /// <summary>
        /// The DataSet name where the Classifier will be trained from
        /// </summary>
        [Required]
        [RegularExpression(Constants.ValidationCommonRegex)]
        [StringLength(Constants.ValidationCommonMaximumLength, MinimumLength = Constants.ValidationCommonMinimumLength)]
        public string DataSetName { get; set; }

        /// <summary>
        /// The list of the tag Ids which will be trained
        /// </summary>
        public List<string> TagIdList { get; set; } = new List<string>();

        /// <summary>
        /// The list of the NGrams which will be trained. The maximum NGram can be the DataSet's NGram
        /// </summary>
        [Required]
        public List<int> NGramList { get; set; } = new List<int>();

        /// <summary>
        /// 
        /// </summary>
        [Range(0, 2)]
        public int CompressLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CompressSettings CompressSettings { get; set; }
    }
}
