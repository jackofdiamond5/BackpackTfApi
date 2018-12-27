using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;

using BackpackTfApi.Classifieds.Templates;
using BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models;

namespace BackpackTfApi.UserToken.Classifieds.Utilities
{
    public static class ClassifiedsSearchHandler
    {
        /// <summary>
        /// Fetches the JSON response from the Classifieds Search endpoint and converts it to a .NET type.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public static Response DownloadJsonData(string uri)
        {
            using (var client = new WebClient())
                return ClassifiedsData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Searches the response object for all listings that match the provided user's ID.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, ICollection<Listing>> GetListingsByUserId(Response response, string userId)
        {
            var buyListings = response.Buy.Listings.Where(l => l.SteamId.Equals(userId)).ToList<Listing>();
            var sellListings = response.Sell.Listings.Where(l => l.SteamId.Equals(userId)).ToList<Listing>();

            return new Dictionary<string, ICollection<Listing>>
            {
                { "BuyListings", buyListings },
                { "SellListings", sellListings }
            };
        }

        /// <summary>
        /// Searches the response object for all listings that match the provided item name.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IDictionary<string, ICollection<Listing>> GetListingsByItemName(Response response, string itemName)
        {
            var buyListings = response.Buy.Listings.Where(l => l.Item.Name.Equals(itemName)).ToList<Listing>();
            var sellListings = response.Sell.Listings.Where(l => l.Item.Name.Equals(itemName)).ToList<Listing>();

            return new Dictionary<string, ICollection<Listing>>
            {
                { "BuyListings", buyListings },
                { "SellListings", sellListings }
            };
        }
    }
}
