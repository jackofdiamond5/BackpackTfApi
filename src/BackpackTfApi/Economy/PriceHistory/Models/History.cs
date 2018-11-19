using Newtonsoft.Json;

namespace BackpackTfApi.Economy.PriceHistory.Models
{
    public class History
    {
        [JsonProperty("value")]
        internal decimal Value { get; set; }

        [JsonProperty("value_high")]
        internal decimal ValueHigh { get; set; }

        [JsonProperty("currency")]
        internal string Currency { get; set; }

        [JsonProperty("timestamp")]
        internal long Timestamp { get; set; }
    }
}
