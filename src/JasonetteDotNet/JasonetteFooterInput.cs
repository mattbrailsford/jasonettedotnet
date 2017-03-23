using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteFooterInput
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public JasonneteFooterInputImageButton Left { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public JasonneteFooterInputLabelButton Right { get; set; }
    }
}