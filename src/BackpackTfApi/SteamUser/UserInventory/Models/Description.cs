using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    /// <summary>
    /// Description object of the user's inventory.
    /// </summary>
    public class Description
    {
        [JsonProperty("appid")]
        public int AppId { get; internal set; }

        [JsonProperty("classid")]
        public string ClassId { get; internal set; }

        [JsonProperty("instanceid")]
        public string InstanceId { get; internal set; }

        [JsonProperty("currency")]
        public decimal? Currency { get; internal set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; internal set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; internal set; }

        [JsonProperty("icon_url_large")]
        public string IconUrlLarge { get; internal set; }

        [JsonProperty("descriptions")]
        public IReadOnlyCollection<ItemDescription> Descriptions { get; internal set; }

        [JsonProperty("tradable")]
        public string Tradable { get; internal set; }

        [JsonProperty("actions")]
        public IReadOnlyCollection<Action> Actions { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("name_color")]
        public string NameColor { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("market_name")]
        public string MarketName { get; internal set; }

        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; internal set; }

        [JsonProperty("market_actions")]
        public IReadOnlyCollection<MarketAction> MarketActions { get; internal set; }

        [JsonProperty("commodity")]
        public int? Commodity { get; internal set; }

        [JsonProperty("market_tradable_restriction")]
        public int? MarketTradableRestriction { get; internal set; }

        [JsonProperty("market_marketable_restriction")]
        public int? MarketMarketableRestriction { get; internal set; }

        [JsonProperty("marketable")]
        public int? Marketable { get; internal set; }

        [JsonProperty("tags")]
        public IReadOnlyCollection<Tag> Tags { get; internal set; }
    }
}
