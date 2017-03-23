using System;
using Newtonsoft.Json;

namespace JasonetteDotNet.Converters
{
    /// <summary>
    /// JsonConverter to force all structs to be serialized as string as this is how
    /// jasonette expects them to be
    /// </summary>
    public class JasonetteStringConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                if (value is bool)
                {
                    writer.WriteValue(value.ToString().ToLowerInvariant());
                }
                else
                {
                    writer.WriteValue(value.ToString());
                }
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsValueType;
        }
    }
}
