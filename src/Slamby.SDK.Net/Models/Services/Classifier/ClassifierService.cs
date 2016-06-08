namespace Slamby.SDK.Net.Models.Services
{
    /// <summary>
    /// For the common properties detail check the [Service](#/definitions/Service)
    /// </summary>
    public class ClassifierService : Service
    {
        public ClassifierPrepareSettings PrepareSettings { get; set; }

        public ClassifierActivateSettings ActivateSettings { get; set; }
    }
}
