using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Item
    {
        [JsonProperty("defindex")]
        internal long[] Defindex { get; set; }

        [JsonProperty("prices")]
        internal Dictionary<string, Price> Prices { get; set; }
    }
}
