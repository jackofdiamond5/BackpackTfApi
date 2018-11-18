using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    internal partial class Price
    {
        [JsonProperty("Tradable")]
        internal Tradable Tradable { get; set; }

        [JsonProperty("Non-Tradable", NullValueHandling = NullValueHandling.Ignore)]
        internal NonTradable NonTradable { get; set; }
    }
}
