using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteLabelLayer : JasonetteLayer
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => "label";

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Style { get; set; }

        public JasonetteLabelLayer(string text, JasonetteAction action)
        {
            this.Text = text;
            this.Action = action;
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}
