using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class ErrorsModel
    {
        public IEnumerable<string> Errors { get; set; }

        public ErrorsModel()
        {
        }

        public ErrorsModel(string error)
        {
            Errors = new[] { error };
        }
    }
}
