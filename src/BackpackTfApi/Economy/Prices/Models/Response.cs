using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Response
    {
        [JsonProperty("success")]
        public long Success { get; set; }

        [JsonProperty("current_time")]
        public long CurrentTime { get; set; }

        [JsonProperty("raw_usd_value")]
        public double RawUsdValue { get; set; }

        [JsonProperty("usd_currency")]
        public Currency UsdCurrency { get; set; }

        [JsonProperty("usd_currency_index")]
        public long UsdCurrencyIndex { get; set; }

        [JsonProperty("items")]
        public Dictionary<string, Item> Items { get; set; }

        internal bool IsInitialized => this.Items != null;
    }
}
