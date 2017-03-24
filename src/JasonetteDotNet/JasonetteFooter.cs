using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteFooter : JasonetteEntity
    {
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteFooterInput Input { get; set; }

        [JsonProperty("tabs", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteTabBar Tabs { get; set; }

        public JasonetteFooter()
        {
            this.Tabs = new JasonetteTabBar();
        }

        public bool ShouldSerializeTabs()
        {
            return !this.Tabs.IsNullOrEmpty();
        }
    }
}