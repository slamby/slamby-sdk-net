using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Stores error messages
    /// </summary>
    public class ErrorsModel
    {
        public List<string> Errors { get; set; }

        public static ErrorsModel Create(string error)
        {
            return Create(new List<string> { error });
        }

        public static ErrorsModel Create(List<string> errors)
        {
            var errorsModel = new ErrorsModel()
            {
                Errors = errors
            };

            return errorsModel;
        }
    }
}