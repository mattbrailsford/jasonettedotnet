using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteSearch
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Style { get; set; }

        public JasonetteSearch()
        {
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}