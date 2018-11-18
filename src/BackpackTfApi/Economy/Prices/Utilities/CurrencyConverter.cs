using System;
using Newtonsoft.Json;

using BackpackTfApi.Economy.Prices.Models;
using BackpackTfApi.Economy.Prices.Static;

namespace BackpackTfApi.Economy.Prices.Utilities
{
    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(Currency) || objectType == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "hat":
                    return Currency.Hat;
                case "keys":
                    return Currency.Keys;
                case "metal":
                    return Currency.Metal;
                case "usd":
                    return Currency.Usd;
            }

            throw new JsonReaderException(Messages.DeserializeCurrencyErrorMessage);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var currency = (Currency)value;
            switch (currency)
            {
                case Currency.Hat:
                    serializer.Serialize(writer, "hat");
                    return;
                case Currency.Keys:
                    serializer.Serialize(writer, "keys");
                    return;
                case Currency.Metal:
                    serializer.Serialize(writer, "metal");
                    return;
                case Currency.Usd:
                    serializer.Serialize(writer, "usd");
                    return;
            }

            throw new JsonWriterException(Messages.SerializeCurrencyErrorMessage);
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }
}
