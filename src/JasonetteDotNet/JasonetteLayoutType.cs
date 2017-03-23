using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JasonetteDotNet
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JasonetteLayoutType
    {
        [EnumMember(Value = JasonetteConstants.LayoutTypes.Vertical)]
        Vertical,

        [EnumMember(Value = JasonetteConstants.LayoutTypes.Horizontal)]
        Horizontal
    }
}