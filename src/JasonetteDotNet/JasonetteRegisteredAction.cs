using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteRegisteredAction : JasonetteAction
    {
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public string Trigger { get; set; }

        public JasonetteRegisteredAction(string trigger)
        {
            this.Trigger = trigger;
        }
    }
}