using System;
using System.Collections.Generic;

using BackpackTfApi.Economy.SpecialItems;
using BackpackTfApi.Economy.Prices.Models;
using BackpackTfApi.Economy.Currencies.Models;
using BackpackTfApi.Economy.PriceHistory.Models;
using BackpackTfApi.WebApiUsers.WebUsers.Models;
using BackpackTfApi.SteamUser.UserInventory.Models;
using BackpackTfApi.WebApiUsers.WebImpersonatedUsers.Models;
using BackpackTfApi.Classifieds.UserToken.UserListings.Models;
using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;
using BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models;

namespace BackpackTfApi
{
    public class BackpackTfUser
    {
        public BackpackTfUser(string steamid64, string apiKey, string accessToken)
        {
            this.SteamId64 = steamid64;
            this.ApiKey = apiKey;
            this.AccessToken = accessToken;
        }

        /// <summary>
        /// The steamid64 associated with a steam account
        /// </summary>
        public string SteamId64 { get; set; }

        /// <summary>
        /// The API key provided by backpack.tf
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The access token provided by backpack.tf
        /// </summary>
        public string AccessToken { get; set; }

        public CurrenciesData GetCurrencies(int raw)
        {
            throw new NotImplementedException();
        }

        public PriceHistoryData GetPriceHistory(string baseItemName, string itemQuality)
        {
            throw new NotImplementedException();
        }

        public PricesData GetPrices(int? raw, long? lastUpdate)
        {
            throw new NotImplementedException();
        }

        public SpecialItemsData GetSpecialItems()
        {
            throw new NotImplementedException();
        }

        public WebUsersData GetUsersByIds(ICollection<string> ids)
        {
            throw new NotImplementedException();
        }

        public ImpersonatedUsersData GetImpersonatedUsers(int? limit, int? skip)
        {
            throw new NotImplementedException();
        }

        public ClassifiedsData GetClassifieds()
        {
            throw new NotImplementedException();
        }

        public UserListingsData GetOwnClassifieds(int? intent, int? inactive)
        {
            throw new NotImplementedException();
        }

        public OutputData CreateBuyListings(Input inputData)
        {
            throw new NotImplementedException();
        }

        public OutputData CreateSellListings(Input inputData)
        {
            throw new NotImplementedException();
        }

        public UserInventoryData GetUserInventory(string steamid64)
        {
            var userInventoryUri =
            $"http://steamcommunity.com/inventory/{this.SteamId64}/{BaseUris.AppId}/2?l=english&count=5000";

            throw new NotImplementedException();
        }

        public UserInventoryData GetOwnInventory()
        {
            var userInventoryUri =
            $"http://steamcommunity.com/inventory/{this.SteamId64}/{BaseUris.AppId}/2?l=english&count=5000";

            throw new NotImplementedException();
        }
    }
}
