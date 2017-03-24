using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteImageTitle : JasonetteTitle
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => JasonetteConstants.TitleTypes.Image;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteImageTitle(string url)
        {
            this.Url = url;
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}