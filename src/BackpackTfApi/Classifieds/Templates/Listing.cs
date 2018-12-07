using System.Collections.Generic;

using Newtonsoft.Json;

using BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models;

namespace BackpackTfApi.Classifieds.Templates
{
    public abstract class Listing
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        // TODO: Generalize the class Item
        [JsonProperty("item")]
        public Item Item { get; internal set; }

        [JsonProperty("currencies")]
        public IReadOnlyDictionary<string, decimal> Currencies { get; internal set; }

        [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offers { get; internal set; }

        [JsonProperty("buyout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Buyout { get; internal set; }

        [JsonProperty("details")]
        public string Details { get; internal set; }
        
        [JsonProperty("intent")]
        public int Intent { get; internal set; }
    }
}
