using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteLayout : JasonetteControl
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteLayoutType Type { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<JasonetteControl> Components { get; set; }

        // TODO: padding, spacing, background, z_index, opacity, align, distribution
        // https://docs.jasonette.com/layout/#styling-a-layout
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Style { get; set; }

        public JasonetteLayout(IEnumerable<JasonetteControl> components, JasonetteLayoutType type = JasonetteLayoutType.Vertical)
        {
            this.Type = type;

            this.Components = new List<JasonetteControl>(components);
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeComponents()
        {
            return !this.Components.IsNullOrEmpty();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}
