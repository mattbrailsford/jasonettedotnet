using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteSection
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteSectionType Type { get; set; }

        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public string Header { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<JasonetteControl> Items { get; set; }

        public JasonetteSection(IEnumerable<JasonetteControl> items, JasonetteSectionType type = JasonetteSectionType.Vertical)
            : this(null, items, type)
        { }

        public JasonetteSection(string header, IEnumerable<JasonetteControl> items, JasonetteSectionType type = JasonetteSectionType.Vertical)
        {
            this.Type = type;
            this.Header = header;
            this.Items = new List<JasonetteControl>(items);
        }

        public bool ShouldSerializeItems()
        {
            return !this.Items.IsNullOrEmpty();
        }
    }
}
