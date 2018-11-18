using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Currencies.Models
{
    internal partial class Price
    {
        [JsonProperty("currency")]
        internal string Currency { get; set; }

        [JsonProperty("value")]
        internal decimal Value { get; set; }

        [JsonProperty("value_high", NullValueHandling = NullValueHandling.Ignore)]
        internal decimal? ValueHigh { get; set; }

        [JsonProperty("value_raw", NullValueHandling = NullValueHandling.Ignore)]
        internal decimal? ValueRaw { get; set; }

        [JsonProperty("value_raw_high", NullValueHandling = NullValueHandling.Ignore)]
        internal decimal? ValueRawHigh { get; set; }

        [JsonProperty("last_update")]
        internal long LastUpdate { get; set; }

        [JsonProperty("difference")]
        internal decimal Dfference { get; set; }

        [JsonProperty("australium", NullValueHandling = NullValueHandling.Ignore)]
        internal int? Australium { get; set; }
    }
}
