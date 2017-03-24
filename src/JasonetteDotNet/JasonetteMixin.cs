using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteMixin : JasonetteEntity
    {
        [JsonProperty("@", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        public JasonetteMixin(string url, string path = null)
        {
            if (!string.IsNullOrEmpty(path))
                url = path + "@" + url;

            this.Url = url;
        }
    }
}
