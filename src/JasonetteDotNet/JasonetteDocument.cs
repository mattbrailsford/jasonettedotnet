using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteDocument : JasonetteEntity
    {
        [JsonProperty("$jason", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteJason Jason { get; set; }

        public JasonetteDocument()
        {
            this.Jason = new JasonetteJason();
        }
    }
}
