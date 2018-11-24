using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public sealed class Action
    {
        [JsonProperty("link")]
        public string Link { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}
