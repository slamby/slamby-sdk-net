using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Stores error messages
    /// </summary>
    public class ErrorsModel
    {
        public List<string> Errors { get; set; } = new List<string>();

        public static ErrorsModel Create(string error)
        {
            return Create(new List<string> { error });
        }

        public static ErrorsModel Create(IEnumerable<string> errors)
        {
            var errorsModel = new ErrorsModel()
            {
                Errors = new List<string>(errors)
            };

            return errorsModel;
        }
    }
}