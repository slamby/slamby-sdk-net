using System;

namespace Slamby.SDK.Net.Helpers
{
    public class RawMessageEventArgs : EventArgs
    {
        public string Message { get; private set; } = string.Empty;

        public RawMessageEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
