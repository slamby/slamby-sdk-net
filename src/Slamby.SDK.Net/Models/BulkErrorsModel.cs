using System.Collections.Generic;

namespace Slamby.SDK.Net.Models
{
    public class BulkErrorsModel
    {
        public List<BulkError> Errors { get; private set; }

        public BulkErrorsModel()
        {
            Errors = new List<BulkError>();
        }
    }
}
