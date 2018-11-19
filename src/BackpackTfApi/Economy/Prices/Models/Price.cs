using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Price
    {
        [JsonProperty("Tradable")]
        public Tradable Tradable { get; internal set; }

        [JsonProperty("Non-Tradable", NullValueHandling = NullValueHandling.Ignore)]
        public NonTradable NonTradable { get; internal set; }
    }
}
