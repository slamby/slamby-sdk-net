namespace Slamby.SDK.Net.Models.Services
{
    /// <summary>
    /// For the common properties detail check the [Service](#/definitions/Service)
    /// </summary>
    public class SearchService : Service
    {
        public SearchPrepareSettings PrepareSettings { get; set; }

        public SearchActivateSettings ActivateSettings { get; set; }
    }
}
