using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteHeader : JasonetteEntity
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteTitle Title { get; set; }

        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteSearch Search { get; set; }

        [JsonProperty("menu", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteMenu Menu { get; set; }
        
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteHeader()
        {
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}