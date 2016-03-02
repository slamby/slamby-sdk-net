namespace Slamby.SDK.Net.Managers
{
    public abstract class BaseManager
    {
        protected Configuration _configuration;
        protected string _endpoint;
        protected ApiClient _client;
        protected BaseManager(Configuration configuration, string endpoint)
        {
            _configuration = configuration;
            _endpoint = endpoint;
            _client = new ApiClient(_configuration, _endpoint);
        }
    }
}
