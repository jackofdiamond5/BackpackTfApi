using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Response
    {
        [JsonProperty("success")]
        public long Success { get; internal set; }

        [JsonProperty("current_time")]
        public long CurrentTime { get; internal set; }

        [JsonProperty("raw_usd_value")]
        public double RawUsdValue { get; internal set; }

        [JsonProperty("usd_currency")]
        public Currency UsdCurrency { get; internal set; }

        [JsonProperty("usd_currency_index")]
        public long UsdCurrencyIndex { get; internal set; }

        [JsonProperty("items")]
        public IReadOnlyDictionary<string, Item> Items { get; internal set; }

        internal bool IsInitialized => this.Items != null;
    }
}
