using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public abstract class JasonetteEntity
    {
        internal JasonetteEntity() { }

        [JsonProperty("@", NullValueHandling = NullValueHandling.Ignore)]
        internal string MixinUrl { get; set; }

        public bool ShouldSerializeMixinUrl()
        {
            return !string.IsNullOrWhiteSpace(MixinUrl);
        }
    }
}