using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Response
    {
        [JsonProperty("success")]
        internal long Success { get; set; }

        [JsonProperty("current_time")]
        internal long CurrentTime { get; set; }

        [JsonProperty("raw_usd_value")]
        internal double RawUsdValue { get; set; }

        [JsonProperty("usd_currency")]
        internal Currency UsdCurrency { get; set; }

        [JsonProperty("usd_currency_index")]
        internal long UsdCurrencyIndex { get; set; }

        [JsonProperty("items")]
        internal Dictionary<string, Item> Items { get; set; }
    }
}
