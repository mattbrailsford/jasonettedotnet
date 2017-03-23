using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JasonetteDotNet
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JasonetteHrefTransition
    {
        [EnumMember(Value = JasonetteConstants.HrefTransitions.Push)]
        Push,

        [EnumMember(Value = JasonetteConstants.HrefTransitions.Modal)]
        Modal,

        [EnumMember(Value = JasonetteConstants.HrefTransitions.Replace)]
        Replace
    }
}