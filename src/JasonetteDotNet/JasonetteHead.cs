using System.Collections.Generic;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteHead : JasonetteEntity
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
        
        [JsonProperty("offline", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Offline { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, Dictionary<string, object>> Styles { get; set; }

        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, JasonetteInlineAction> Actions { get; set; }

        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Templates { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Data { get; set; }

        public JasonetteHead()
        {
            this.Styles = new Dictionary<string, Dictionary<string, object>>();
            this.Actions = new Dictionary<string, JasonetteInlineAction>();
            this.Templates = new Dictionary<string, object>();
            this.Data = new Dictionary<string, object>();
        }

        public bool ShouldSerializeStyles()
        {
            return !this.Styles.IsNullOrEmpty();
        }

        public bool ShouldSerializeActions()
        {
            return !this.Actions.IsNullOrEmpty();
        }

        public bool ShouldSerializeTemplates()
        {
            return !this.Templates.IsNullOrEmpty();
        }

        public bool ShouldSerializeData()
        {
            return !this.Data.IsNullOrEmpty();
        }
    }
}