using System;
using System.Net;
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
using BackpackTfApi.Economy.Currencies.Static;

namespace BackpackTfApi
{
    public class BackpackTfUser
    {
        private string steamId64 = "";
        private string apiKey = "";
        private string accessToken = "";

        public BackpackTfUser(string steamid64, string apiKey, string accessToken)
        {
            this.SteamId64 = steamid64;
            this.ApiKey = apiKey;
            this.AccessToken = accessToken;
        }

        /// <summary>
        /// The steamid64 associated with a steam account
        /// </summary>
        public string SteamId64
        {
            get => this.steamId64;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();

                this.steamId64 = value;
            }
        }

        /// <summary>
        /// The API key provided by backpack.tf
        /// </summary>
        public string ApiKey
        {
            get => this.apiKey;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();

                this.apiKey = value;
            }
        }

        /// <summary>
        /// The access token provided by backpack.tf
        /// </summary>
        public string AccessToken
        {
            get => this.accessToken;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();

                this.accessToken = value;
            }
        }

        /// <summary>
        /// Returns internal currency data for Team Fortress 2. 
        /// </summary>
        /// <param name="raw">
        /// Set to 1 to include a ValueRaw property in the Price model(s). 
        /// Set to 2 to include a ValueRawHigh property in the Price model(s).
        /// </param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public CurrenciesData GetCurrencies(int raw = 0)
        {
            var uri = new Uri(BaseUris.GetCurrencies + $"{this.ApiKey}&raw={raw}");
            return CurrenciesHandler.DownloadCurrencyData(uri.ToString());
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
            $"http://steamcommunity.com/inventory/{steamid64}/{BaseUris.AppId}/2?l=english&count=5000";

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
