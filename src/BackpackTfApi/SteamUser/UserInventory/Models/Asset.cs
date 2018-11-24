using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    /// <summary>
    /// Asset object of the user's inventory.
    /// </summary>
    public class Asset
    {
        [JsonProperty("appid")]
        public int AppId { get; internal set; }

        [JsonProperty("contextid")]
        public string ContextId { get; internal set; }

        [JsonProperty("assetid")]
        public string AssetId { get; internal set; }

        [JsonProperty("classid")]
        public string ClassId { get; internal set; }

        [JsonProperty("instanceid")]
        public string InstanceId { get; internal set; }

        [JsonProperty("amount")]
        public string Amount { get; internal set; }
    }
}
