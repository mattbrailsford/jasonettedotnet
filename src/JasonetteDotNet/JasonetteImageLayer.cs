using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteImageLayer : JasonetteLayer
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => "image";

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteImageLayer(string url, JasonetteAction action)
        {
            this.Url = url;
            this.Action = action;
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}