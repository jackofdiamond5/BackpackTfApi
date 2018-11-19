using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class CraftableElement
    {
        [JsonProperty("value")]
        public double? Value { get; internal set; }

        [JsonProperty("currency")]
        public Currency? Currency { get; internal set; }

        [JsonProperty("difference")]
        public double? Difference { get; internal set; }

        [JsonProperty("last_update")]
        public long? LastUpdate { get; internal set; }

        [JsonProperty("value_high", NullValueHandling = NullValueHandling.Ignore)]
        public double? ValueHigh { get; internal set; }

        [JsonProperty("australium", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Australium { get; internal set; }
    }
}
