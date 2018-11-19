using Newtonsoft.Json;
using System.Collections.Generic;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class NonTradable
    {
        [JsonProperty("Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal ICollection<CraftableElement> Craftable { get; set; }

        [JsonProperty("Non-Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal ICollection<CraftableElement> NonCraftable { get; set; }
    }
}
