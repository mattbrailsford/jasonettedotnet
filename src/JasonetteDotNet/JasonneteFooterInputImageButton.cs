using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonneteFooterInputImageButton
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteAction Action { get; set; }

        public JasonneteFooterInputImageButton(string url, JasonetteAction action)
        {
            this.Url = url;
            this.Action = action;
        }
    }
}