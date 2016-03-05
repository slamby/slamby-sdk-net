using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class ErrorsModel
    {
        public IEnumerable<string> Errors { get; set; }

        public static ErrorsModel Create(string error)
        {
            var errorsModel = new ErrorsModel();
            errorsModel.Errors =  new[] { error };
            return errorsModel;
        }
    }
}
