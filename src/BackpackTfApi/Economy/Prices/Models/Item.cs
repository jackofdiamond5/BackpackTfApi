using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Item
    {
        [JsonProperty("defindex")]
        internal ICollection<long> Defindex { get; set; }

        [JsonProperty("prices")]
        internal IDictionary<string, Price> Prices { get; set; }
    }
}
