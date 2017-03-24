using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteJason : JasonetteEntity
    {
        [JsonProperty("head", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteHead Head { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public JasonetteBody Body { get; set; }

        public JasonetteJason()
        {
            this.Head = new JasonetteHead();
            this.Body = new JasonetteBody();
        }

        //public static JasonetteJason Mixin(string url, string path = null)
        //{
        //    return new JasonetteJason { MixinUrl = url };
        //}
    }
}