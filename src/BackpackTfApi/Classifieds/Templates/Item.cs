using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models
{
    public abstract class Item
    {
        [JsonProperty("defindex")]
        public int Defindex { get; internal set; }

        [JsonProperty("quality")]
        public int Quality { get; internal set; }

        [JsonProperty("attributes")]
        public IReadOnlyCollection<Attribute> Attributes { get; internal set; }

        [JsonProperty("user-id")]
        public string UserId { get; internal set; }

        [JsonProperty("quantity")]
        public string Quantity { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("marketplace_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MarketplacePrice { get; internal set; }
    }
}
