using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteImageComponent : JasonetteStyledComponent
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => "image";

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        public JasonetteImageComponent(string url)
        {
            this.Url = url;
        }
    }
}
