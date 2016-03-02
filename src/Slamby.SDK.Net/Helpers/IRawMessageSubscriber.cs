namespace Slamby.SDK.Net.Helpers
{
    public interface IRawMessageSubscriber
    {
        void OnRawDataPublish(object sender, RawMessageEventArgs args);
    }
}
