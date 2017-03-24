using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public abstract class JasonetteMenu : JasonetteEntity
    {
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteHref Href { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        [JsonProperty("badge", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteBadge Badge { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        protected JasonetteMenu()
        {
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}