using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using BackpackTfApi.Static;
using BackpackTfApi.Economy.Prices.Models;
using BackpackTfApi.Economy.Prices.Templates;

namespace BackpackTfApi.Economy.Prices.Utilities
{
    internal class CraftableUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(CraftableUnion) || objectType == typeof(CraftableUnion?);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, CraftableElement>>(reader);
                    return new CraftableUnion { CraftableElementMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<CraftableElement[]>(reader);
                    return new CraftableUnion { CraftableElementArray = arrayValue };
            }

            throw new JsonReaderException(Messages.CraftableUnionDeserializeErrorMessage);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var craftableTemplate = (CraftableUnion)value;
            if (craftableTemplate.CraftableElementArray != null)
            {
                serializer.Serialize(writer, craftableTemplate.CraftableElementArray);
                return;
            }
            if (craftableTemplate.CraftableElementMap != null)
            {
                serializer.Serialize(writer, craftableTemplate.CraftableElementMap);
                return;
            }

            throw new JsonWriterException(Messages.CraftableUnionSerializeErrorMessage);
        }

        public static readonly CraftableUnionConverter Singleton = new CraftableUnionConverter();
    }
}
