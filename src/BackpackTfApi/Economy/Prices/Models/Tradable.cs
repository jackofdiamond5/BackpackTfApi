using Newtonsoft.Json;

using BackpackTfApi.Economy.Prices.Templates;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Tradable
    {
        [JsonProperty("Craftable", NullValueHandling = NullValueHandling.Ignore)]
        public CraftableUnion? Craftable { get; internal set; }

        [JsonProperty("Non-Craftable", NullValueHandling = NullValueHandling.Ignore)]
        public CraftableUnion? NonCraftable { get; internal set; }
    }
}
