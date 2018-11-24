using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public sealed class Tag
    {
        [JsonProperty("category")]
        public string Category { get; internal set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; internal set; }

        [JsonProperty("localized_category_name")]
        public string LocalizedCategoryName { get; internal set; }

        [JsonProperty("color")]
        public string Color { get; internal set; }
    }
}
