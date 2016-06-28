﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcKeywordsRequest
    {
        /// <summary>
        /// The text which you want to extract the keywords from
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// The extracting keywords calculation depends on this Tag
        /// </summary>
        [Required]
        public string TagId { get; set; }
    }
}