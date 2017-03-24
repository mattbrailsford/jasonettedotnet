using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteBody : JasonetteEntity
    {
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteHeader Header { get; set; }
        
        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore)]
        public IList<JasonetteSection> Sections { get; set; }

        [JsonProperty("layers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<JasonetteLayer> Layers { get; set; }
        
        [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteFooter Footer { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteBody()
        {
            this.Header = new JasonetteHeader();
            this.Sections = new List<JasonetteSection>();
            this.Layers = new List<JasonetteLayer>();
            this.Footer = new JasonetteFooter();
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeSections()
        {
            return !this.Sections.IsNullOrEmpty();
        }

        public bool ShouldSerializeLayers()
        {
            return !this.Layers.IsNullOrEmpty();
        }

        //public bool ShouldSerializeFooter()
        //{
        //    return this.Footer != null && (this.Footer.Input != null || (this.F))
        //}

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }
    }
}