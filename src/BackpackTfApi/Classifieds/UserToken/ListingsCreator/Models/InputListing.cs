﻿using Newtonsoft.Json;

using System.Collections.Generic;

using BackpackTfApi.Classifieds.Templates;
using BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class InputListing : Listing
    {
        public InputListing(
            string id,
            ListingItem item,
            IReadOnlyDictionary<string, decimal> currencies,
            string details,
            int? offers = 1,
            int? buyOut = 1,
            int? promoted = 0)
        {
            this.Id = id;
            this.Item = item;
            this.Currencies = currencies;
            this.Details = details;
            this.Offers = offers;
            this.Buyout = buyOut;
            this.Promoted = promoted;
        }

        [JsonProperty("promoted")]
        public int? Promoted { get; internal set; }

        [JsonProperty("item")]
        public new ListingItem Item { get; internal set; }
    }
}
