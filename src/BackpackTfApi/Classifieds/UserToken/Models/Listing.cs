using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.Models
{
    public class Listing
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("steamid")]
        public string SteamId { get; internal set; }

        [JsonProperty("item")]
        public Item Item { get; internal set; }

        [JsonProperty("appid")]
        public int AppId { get; internal set; }

        [JsonProperty("currencies")]
        public IReadOnlyDictionary<string, decimal> Currencies { get; internal set; }

        [JsonProperty("offers")]
        public int Offers { get; internal set; }

        [JsonProperty("buyout")]
        public int Buyout { get; internal set; }
       
        [JsonProperty("details")]
        public string Details { get; internal set; }

        [JsonProperty("created")]
        public long Created { get; internal set; }

        [JsonProperty("bump")]
        public long Bump { get; internal set; }

        [JsonProperty("intent")]
        public int Intent { get; internal set; }
    }
}
