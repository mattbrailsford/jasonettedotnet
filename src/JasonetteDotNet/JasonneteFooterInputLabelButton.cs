using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonneteFooterInputLabelButton
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        public JasonneteFooterInputLabelButton(string text, JasonetteAction action)
        {
            this.Text = text;
            this.Action = action;
        }
    }
}