using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public sealed class ItemDescription
    {
        [JsonProperty("value")]
        public string Value { get; internal set; }

        [JsonProperty("color")]
        public string Color { get; internal set; }
    }
}
