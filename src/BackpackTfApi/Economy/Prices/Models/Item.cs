using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Item
    {
        [JsonProperty("defindex")]
        public ICollection<long> Defindex { get; internal set; }

        [JsonProperty("prices")]
        public IDictionary<string, Price> Prices { get; internal set; }
    }
}
