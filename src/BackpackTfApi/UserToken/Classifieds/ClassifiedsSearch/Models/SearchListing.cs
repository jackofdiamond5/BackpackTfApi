﻿using Newtonsoft.Json;

using BackpackTfApi.UserToken.Classifieds.Templates;

namespace BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models
{
    public class SearchListing : Listing
    {
        [JsonProperty("steamid")]
        public string SteamId { get; internal set; }

        [JsonProperty("appid")]
        public int AppId { get; internal set; }
        
        [JsonProperty("created")]
        public long Created { get; internal set; }

        [JsonProperty("bump")]
        public long Bump { get; internal set; }

        [JsonProperty("item")]
        public new SearchItem Item { get; internal set; }
    }
}
