using Newtonsoft.Json;

using System.Collections.Generic;

using BackpackTfApi.UserToken.Classifieds.Templates;

namespace BackpackTfApi.UserToken.Classifieds.ListingsCreator.Models
{
    public class InputListing : Listing
    {
        public InputListing(
            int intent,
            IReadOnlyDictionary<string, decimal> currencies,
            string details,
            string assetid = null,
            ListingItem item = null,
            int? offers = null,
            int? buyOut = null,
            int? promoted = null)
        {
            this.AssetId = assetid;
            this.Item = item;
            this.Currencies = currencies;
            this.Details = details;
            this.Offers = offers;
            this.Buyout = buyOut;
            this.Promoted = promoted;
            this.Intent = intent;
        }

        [JsonProperty("promoted", NullValueHandling = NullValueHandling.Ignore)]
        public int? Promoted { get; internal set; }

        /// <summary>
        /// Used for Buy Listings.
        /// </summary>
        [JsonProperty("item")]
        public new ListingItem Item { get; internal set; }
    }
}
