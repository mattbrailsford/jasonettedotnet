using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JasonetteDotNet
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JasonetteSectionType     
    {
        [EnumMember(Value = JasonetteConstants.SectionTypes.Vertical)]
        Vertical,

        [EnumMember(Value = JasonetteConstants.SectionTypes.Horizontal)]
        Horizontal
    }
}