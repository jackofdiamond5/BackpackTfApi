using Newtonsoft.Json;

using BackpackTfApi.Economy.Prices.Templates;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class Tradable
    {
        [JsonProperty("Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal CraftableUnion? Craftable { get; set; }

        [JsonProperty("Non-Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal CraftableUnion? NonCraftable { get; set; }
    }
}
