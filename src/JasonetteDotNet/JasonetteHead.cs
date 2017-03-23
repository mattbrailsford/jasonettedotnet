using System.Collections.Generic;
using JasonetteDotNet.Converters;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteHead
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
        
        [JsonProperty("offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool Offline { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, object>> Styles { get; set; }

        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, JasonetteInlineAction> Actions { get; set; }

        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Templates { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Data { get; set; }

        public JasonetteHead()
        {
            this.Styles = new Dictionary<string, Dictionary<string, object>>();
            this.Actions = new Dictionary<string, JasonetteInlineAction>();
            this.Templates = new Dictionary<string, object>();
            this.Data = new Dictionary<string, object>();
        }

        public bool ShouldSerializeOffline()
        {
            return this.Offline;
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