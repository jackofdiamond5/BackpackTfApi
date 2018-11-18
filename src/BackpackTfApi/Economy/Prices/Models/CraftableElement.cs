using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    internal partial class CraftableElement
    {
        [JsonProperty("value")]
        internal double? Value { get; set; }

        [JsonProperty("currency")]
        internal Currency? Currency { get; set; }

        [JsonProperty("difference")]
        internal double? Difference { get; set; }

        [JsonProperty("last_update")]
        internal long? LastUpdate { get; set; }

        [JsonProperty("value_high", NullValueHandling = NullValueHandling.Ignore)]
        internal double? ValueHigh { get; set; }

        [JsonProperty("australium", NullValueHandling = NullValueHandling.Ignore)]
        internal bool? Australium { get; set; }
    }
}
