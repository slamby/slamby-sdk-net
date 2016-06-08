using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// DataSet object
    /// </summary>
    public class DataSet
    {
        /// <summary>
        /// Name of your dataset. Contains just A-Z letters and numbers without any space. This field is unique
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// To deeper analyze your text, a dataset uses ngram to index your document. You can set the ngramcount from 1 to 6
        /// </summary>
        [Required]
        public int NGramCount { get; set; }

        /// <summary>
        /// To identify a document you need to use IDs. You can use your own conventions to name your ID field, but in the settings you need to provide the field name of the id field from your sample document
        /// </summary>
        [Required]
        public string IdField { get; set; }

        /// <summary>
        /// For text categorization we provide a predefined document field to store your tags (or categories). If your documents are related to tags or categories, please insert here the tags field name from your sample JSON
        /// </summary>
        [Required]
        public string TagField { get; set; }

        /// <summary>
        /// For text analysis you can set those document fields that contains useful text content. Slamby is doing ngram analysis and text process related works on these fields. How to decide which field you need to set here? Only the interpreted field can be a part of text analyzes. To provide these fields just simply insert the needed text fields from your JSON document
        /// </summary>
        [Required]
        public List<string> InterpretedFields { get; set; }

        /// <summary>
        /// These are read only calculated values
        /// </summary>
        public DataSetStats Statistics { get; set; }

        /// <summary>
        /// Using flexible document schema, you can store all of your required data inside one simple dataset. To create a dataset with your required schema you can provide a sample document. The schema is flexible; the only requirement is using standard JSON format
        /// </summary>
        public object SampleDocument { get; set; }

        /// <summary>
        /// Using flexible document schema, you can store all of your required data inside one simple dataset. To create a dataset with your required schema you can provide a schema. The schema is flexible
        /// </summary>
        public object Schema { get; set; }
    }
}
