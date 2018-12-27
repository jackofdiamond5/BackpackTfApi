using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models
{
    public class Intent
    {
        [JsonProperty("total")]
        public int Total { get; internal set; }

        [JsonProperty("listings")]
        public IReadOnlyCollection<SearchListing> Listings { get; internal set; }

        [JsonProperty("fold")]
        public bool Fold { get; internal set; }
    }
}