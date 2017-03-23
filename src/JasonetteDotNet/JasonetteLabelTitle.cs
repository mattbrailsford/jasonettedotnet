using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteLabelTitle : JasonetteTitle
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => JasonetteConstants.TitleTypes.Label;

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public JasonetteLabelTitle(string text)
        {
            this.Text = text;
        }
    }
}