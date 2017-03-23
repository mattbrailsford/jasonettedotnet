using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteLabelMenu : JasonetteMenu
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public JasonetteLabelMenu(string text, JasonetteHref href)
        {
            this.Text = text;
            this.Href = href;
        }

        public JasonetteLabelMenu(string text, JasonetteAction action)
        {
            this.Text = text;
            this.Action = action;
        }
    }
}