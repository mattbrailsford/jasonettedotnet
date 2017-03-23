using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteHref
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string View { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Options { get; set; }

        [JsonProperty("transition", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteHrefTransition Transition { get; set; }

        public JasonetteHref(string url)
        {
            this.Url = url;
            this.Options = new Dictionary<string, object>();
        }

        public bool ShouldSerializeOptions()
        {
            return !this.Options.IsNullOrEmpty();
        }

        public static implicit operator JasonetteHref(string url)
        {
            return new JasonetteHref(url);
        }
    }
}
