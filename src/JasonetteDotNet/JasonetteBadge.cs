using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteBadge : JasonetteEntity
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteBadge(string text)
        {
            this.Text = text;

            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }

        public static implicit operator JasonetteBadge(string text)
        {
            return new JasonetteBadge(text);
        }
    }
}