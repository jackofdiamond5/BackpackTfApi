using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class NonTradable
    {
        [JsonProperty("Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal CraftableElement[] Craftable { get; set; }

        [JsonProperty("Non-Craftable", NullValueHandling = NullValueHandling.Ignore)]
        internal CraftableElement[] NonCraftable { get; set; }
    }
}
