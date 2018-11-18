using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using BackpackTfApi.Economy.Prices.Utilities;

namespace BackpackTfApi.Economy.Prices.Static
{
    internal static class Converter
    {
        internal static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                CurrencyConverter.Singleton,
                CraftableUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
