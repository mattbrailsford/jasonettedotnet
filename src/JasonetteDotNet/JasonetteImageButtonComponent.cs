using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteImageButtonComponent : JasonetteStyledComponent
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => "button";

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        public JasonetteImageButtonComponent(string url)
        {
            this.Url = url;
        }
    }
}
