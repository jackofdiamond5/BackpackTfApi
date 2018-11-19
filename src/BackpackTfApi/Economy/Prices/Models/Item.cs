using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Item
    {
        [JsonProperty("defindex")]
        public IReadOnlyCollection<long> Defindex { get; internal set; }

        [JsonProperty("prices")]
        public IReadOnlyDictionary<string, Price> Prices { get; internal set; }
    }
}
