using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Currencies.Models
{
    public partial class CurrencyType
    {
        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("quality")]
        internal string Quality { get; set; }

        [JsonProperty("priceindex")]
        internal string PriceIndex { get; set; }

        [JsonProperty("single")]
        internal string Single { get; set; }

        [JsonProperty("plural")]
        internal string Plural { get; set; }

        [JsonProperty("round")]
        internal int Rount { get; set; }

        [JsonProperty("craftable")]
        internal string Craftable { get; set; }

        [JsonProperty("defindex")]
        internal int Defindex { get; set; }

        [JsonProperty("active")]
        internal int Active { get; set; }

        [JsonProperty("blanket", NullValueHandling = NullValueHandling.Ignore)]
        internal int? Blanket { get; set; }

        [JsonProperty("price")]
        internal Price Price { get; set; }
    }
}
