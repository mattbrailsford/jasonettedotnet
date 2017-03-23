using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteLabelButtonComponent : JasonetteStyledComponent
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => "button";

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public JasonetteLabelButtonComponent(string text)
        {
            this.Text = text;
        }
    }
}
