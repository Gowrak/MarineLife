namespace MarineLife.Web.Version
{
    public class Version
    {
        public string BaseVersion { get; set; }

        public string SwaggerVersion => $"v{BaseVersion}";
    }
}