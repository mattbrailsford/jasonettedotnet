using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteInlineAction : JasonetteAction
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Options { get; set; }

        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Success { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Error { get; set; }

        public JasonetteInlineAction(string type, Dictionary<string, object> options = null)
        {
            this.Type = type;
            this.Options = options;
        }

        public bool ShouldSerializeOptions()
        {
            return !this.Options.IsNullOrEmpty();
        }
    }
}