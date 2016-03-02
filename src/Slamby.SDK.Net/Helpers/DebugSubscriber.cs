using System.Diagnostics;

namespace Slamby.SDK.Net.Helpers
{
    public class DebugSubscriber : IRawMessageSubscriber
    {
        public void OnRawDataPublish(object sender, RawMessageEventArgs args)
        {
            Debug.WriteLine(args.Message);
        }
    }
}
