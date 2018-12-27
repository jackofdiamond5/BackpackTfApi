using System.Collections.Generic;

using Newtonsoft.Json;

using BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models;

namespace BackpackTfApi.UserToken.Classifieds.UserListings.Models
{
    public class Response
    {
        [JsonProperty("cap")]
        public int Cap { get; internal set; }

        [JsonProperty("promotes_remaining")]
        public int PromotesRemaining { get; internal set; }

        [JsonProperty("items")]
        public IReadOnlyCollection<SearchItem> Items { get; internal set; }
    }
}
