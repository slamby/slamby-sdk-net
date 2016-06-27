using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    public class DocumentSampleSettings
    {
        /// <summary>
        /// It must be a random string for every new sampling, but must be the same for the same sampling during pagination. 
        /// If you leave it empty than it'll be generated automatically, but then you can not use pagination
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// You can create a sample from a whole dataset, or just from a given tag section. 
        /// To create a sample from the whole dataset please keep it empty. 
        /// To create a sample from a given number of tags please provide the tag ids
        /// </summary>
        public List<string> TagIds { get; set; }

        /// <summary>
        /// You can use stratified sampling. In this case the sampling will be created by tags. For general sampling don't use stratified sampling
        /// </summary>
        public bool IsStratified { get; set; }

        /// <summary>
        /// Pagination object
        /// </summary>
        [Required]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Defining the sample size, you can use percentage or a given number. 
        /// Using a percentage you can define the document number by a percentage. 
        /// This percentage will calculate the document number by using the available dataset document number. 
        /// E.g.: if your dataset contains 100.000 documents and you are using 10% as a sampling size without stratified method, your sample size is 100.000 x 10% = 10.000
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Define your sample size by providing a simple integer. 
        /// E.g.: if your dataset contains 100.000 documents and you are using 3.000 as a sampling size without stratified method, your sample size is 3.000
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Query returns only with the specified field(s)
        /// </summary>
        public List<string> Fields { get; set; } = new List<string>();
    }
}
