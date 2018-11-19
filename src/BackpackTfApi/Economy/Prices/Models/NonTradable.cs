using Newtonsoft.Json;
using System.Collections.Generic;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class NonTradable
    {
        [JsonProperty("Craftable", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyCollection<CraftableElement> Craftable { get; internal set; }

        [JsonProperty("Non-Craftable", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyCollection<CraftableElement> NonCraftable { get; internal set; }
    }
}
