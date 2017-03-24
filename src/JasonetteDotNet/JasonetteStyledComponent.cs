using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public abstract class JasonetteStyledComponent : JasonetteComponent
    {
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        protected JasonetteStyledComponent()
        {
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}
