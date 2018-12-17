using System;
using System.Net;
using System.Text;
using System.Collections.Generic;

using BackpackTfApi.Economy.SpecialItems;
using BackpackTfApi.Economy.Prices.Models;
using BackpackTfApi.Economy.Currencies.Models;
using BackpackTfApi.Economy.Currencies.Static;
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

        /// <summary>
        /// Returns the price history for the specified item.
        /// </summary>
        /// <param name="baseItemName"></param>
        /// <param name="itemQuality"></param>
        /// <param name="tradable"></param>
        /// <param name="craftable"></param>
        /// <param name="priceIndex"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="WebException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public PriceHistoryData GetPriceHistory(string baseItemName, int itemQuality,
            bool tradable = true, bool craftable = true, int priceIndex = 0)
        {
            var isTradable = tradable ? "Tradable" : "Non-Tradable";
            var isCraftable = craftable ? "Craftable" : "Non-Craftable";
            var uriValue = this.BuildUri(BaseUris.GetPriceHistory,
                this.ApiKey,
                $"item={baseItemName}",
                $"appid={BaseUris.AppId}",
                $"tradable={isTradable}",
                $"craftable={isCraftable}",
                $"priceindex={priceIndex}",
                $"quality={itemQuality}");

            using (var client = new WebClient())
                return PriceHistoryData.FromJson(client.DownloadString(uriValue));
        }

        /// <summary>
        /// Fetches item prices for the specified API key. 
        /// A request may be sent once every 60 seconds. 
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="since"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public PricesData GetItemPrices(int raw = 0, int since = 0)
        {
            var uriValue = this.BuildUri(BaseUris.GetPrices,
                this.ApiKey,
                $"raw={raw}",
                $"since={since}");

            using (var client = new WebClient())
                return PricesData.FromJson(client.DownloadString(uriValue));
        }

        /// <summary>
        /// Gets special items for the specified API key.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public SpecialItemsData GetSpecialItems()
        {
            var uri = this.BuildUri(BaseUris.GetSpecialItems, this.ApiKey, $"appid={BaseUris.AppId}");
            using (var client = new WebClient())
                return SpecialItemsData.FromJson(client.DownloadString(uri));
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

        private string BuildUri(string baseUri, params string[] args)
        {
            var builder = new StringBuilder();
            builder.Append(baseUri);
            foreach (var arg in args)
            {
                builder.Append($"{arg}&");
            }

            return builder.ToString().TrimEnd('&');
        }
    }
}
