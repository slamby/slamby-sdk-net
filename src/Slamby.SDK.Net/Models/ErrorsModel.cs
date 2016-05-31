using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    /// <summary>
    /// Stores error messages
    /// </summary>
    public class ErrorsModel
    {
        public IEnumerable<string> Errors { get; set; }

        public static ErrorsModel Create(string error)
        {
            return Create(new[] { error });
        }

        public static ErrorsModel Create(IEnumerable<string> errors)
        {
            var errorsModel = new ErrorsModel()
            {
                Errors = errors
            };

            return errorsModel;
        }
    }
}