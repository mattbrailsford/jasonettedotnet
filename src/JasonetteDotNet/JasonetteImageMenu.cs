using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteImageMenu : JasonetteMenu
    {
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        public JasonetteImageMenu(string image, JasonetteHref href)
        {
            this.Image = image;
            this.Href = href;
        }

        public JasonetteImageMenu(string image, JasonetteAction action)
        {
            this.Image = image;
            this.Action = action;
        }
    }
}