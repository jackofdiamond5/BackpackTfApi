using System.Collections.Generic;

using Newtonsoft.Json;

using BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models;

namespace BackpackTfApi.Classifieds.Templates
{
    public abstract class Listing
    {
        /// <summary>
        /// Used for Sell Listings.
        /// </summary>
        [JsonProperty("id")]
        public string AssetId { get; internal set; }
        
        /// <summary>
        /// An item that corresponds to a specific listing.
        /// </summary>
        [JsonProperty("item")]
        public Item Item { get; internal set; }

        /// <summary>
        /// Collection of currency type, value - metal, 5.
        /// </summary>
        [JsonProperty("currencies")]
        public IReadOnlyDictionary<string, decimal> Currencies { get; internal set; }

        [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offers { get; internal set; }

        [JsonProperty("buyout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Buyout { get; internal set; }

        /// <summary>
        /// Message to be displayed on the listing.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; internal set; }

        /// <summary>
        /// Intent of the listing. Can be either 0 - buy, or 1 - sell.
        /// </summary>
        [JsonProperty("intent")]
        public int Intent { get; internal set; }
    }
}
