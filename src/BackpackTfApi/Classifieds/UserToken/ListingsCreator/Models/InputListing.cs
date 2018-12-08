using Newtonsoft.Json;

using System.Collections.Generic;

using BackpackTfApi.Classifieds.Templates;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
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
            this.Id = assetid;
            this.Item = item;
            this.Currencies = currencies;
            this.Details = details;
            this.Offers = offers;
            this.Buyout = buyOut;
            this.Promoted = promoted;
            this.Intent = intent;
        }

        [JsonProperty("promoted")]
        public int? Promoted { get; internal set; }

        [JsonProperty("item")]
        public new ListingItem Item { get; internal set; }
    }
}
