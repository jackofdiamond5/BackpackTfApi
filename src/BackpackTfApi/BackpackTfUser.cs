using System;
using System.Net;
using System.Text;
using System.Collections.Generic;

using BackpackTfApi.Static;
using BackpackTfApi.Exceptions;
using BackpackTfApi.Economy.SpecialItems;
using BackpackTfApi.Economy.Prices.Models;
using BackpackTfApi.Economy.Currencies.Models;
using BackpackTfApi.Economy.Currencies.Static;
using BackpackTfApi.Economy.PriceHistory.Models;
using BackpackTfApi.WebApiUsers.WebUsers.Models;
using BackpackTfApi.SteamUser.UserInventory.Models;
using BackpackTfApi.UserToken.Classifieds.Utilities;
using BackpackTfApi.WebApiUsers.WebImpersonatedUsers.Models;
using BackpackTfApi.UserToken.Classifieds.UserListings.Models;
using BackpackTfApi.UserToken.Classifieds.ListingsCreator.Models;
using BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models;

namespace BackpackTfApi
{
    public class BackpackTfUser
    {
        private string steamId64 = "";
        private string apiKey = "";
        private string accessToken = "";

        private SteamUser.UserInventory.Models.Response userInventory = null;

        public BackpackTfUser(string steamid64, string apiKey, string accessToken)
        {
            this.SteamId64 = steamid64;
            this.ApiKey = apiKey;
            this.AccessToken = accessToken;

            this.userInventory = this.GetOwnInventory();
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

        /// <summary>
        /// Fetch users data for an array of SteamId64-s.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public WebUsersData GetUsersByIds(ICollection<string> ids)
        {
            var uri = this.BuildUri(BaseUris.GetUsers,
                this.ApiKey,
                $"steamids={string.Join(',', ids)}");
            using (var client = new WebClient())
                return WebUsersData.FromJson(client.DownloadString(uri));

        }

        /// <summary>
        /// Get impersonated users for a user's SteamId64.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public ImpersonatedUsersData GetImpersonatedUsers(int limit = 0, int skip = 0)
        {
            var uri = this.BuildUri(BaseUris.GetImpersonatedUsers,
                this.ApiKey,
                $"limit={limit}",
                $"skip={skip}");
            using (var client = new WebClient())
                return ImpersonatedUsersData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Fetches all currently opened classifieds that are on bacpkack.tf.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public UserToken.Classifieds.ClassifiedsSearch.Models.Response GetClassifieds()
        {
            var uri = this.BuildUri(BaseUris.ClassifiedsSearch, this.ApiKey);
            using (var client = new WebClient())
                return ClassifiedsData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Fetches the currently opened user's classifieds from backpack.tf.
        /// </summary>
        /// <param name="intent">0 - Buy Listings 1 - Sell Listings. Returns both if not set.</param>
        /// <param name="inactive">0 - Include inactive listings. 1 - Skip inactive listings.</param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public UserToken.Classifieds.UserListings.Models.Response GetOwnClassifieds(int? intent = null, int inactive = 1)
        {
            var uri = this.BuildUri(BaseUris.UserListings,
                this.AccessToken,
                $"intent={intent}",
                $"inactive={inactive}");
            using (var client = new WebClient())
                return UserListingsData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Creates a sell listing / classified on backpack.tf.
        /// </summary>
        /// <param name="fullItemName">The item's full name and type - Unusual Larrikin Robin. 
        /// Can also be its defindex.</param>
        /// <param name="currency">The currency type.</param>
        /// <param name="price">The price for which the listing will be created.</param>
        /// <param name="message">The text that will be typed in the message section of the listing.</param>
        /// <exception cref="ItemNotFoundException"></exception>
        /// <exception cref="ItemCreationFailureException"></exception>
        /// <returns></returns>
        public UserToken.Classifieds.ListingsCreator.Models.Response CreateSellListing(
            string fullItemName, string currency, decimal price, string message)
        {
            Asset itemAsset = null;
            try
            {
                itemAsset = InventoryHandler.GetItemAsset(this.userInventory, fullItemName);
            }
            catch (WebException)
            {
                throw new ItemNotFoundException(Messages.ItemNotFoundError);
            }

            var currencies = new Dictionary<string, decimal>
            {
                { currency, price }
            };
            var listings = new List<InputListing>
            {
                new InputListing(1, currencies, message, itemAsset.AssetId)
            };

            if (itemAsset != null)
            {
                var uri = this.BuildUri(BaseUris.ClassifiedsCreate, this.AccessToken);
                return UserListingsHandler.CreateListings(new Input(listings), uri);
            }

            throw new ItemCreationFailureException($"Failed to create listing for item - {fullItemName}");
        }

        /// <summary>
        /// Creates a buy listing / classified on backpack.tf.
        /// </summary>
        /// <param name="fullItemName">The item's full name and type - Unusual Larrikin Robin. 
        /// Can also be its defindex.</param>
        /// <param name="qualityIndex">Quality name or index of the item.</param>
        /// <param name="currency">The currency type.</param>
        /// <param name="price">The price for which the listing will be created.</param>
        /// <param name="message">The text that will be typed in the message section of the listing.</param>
        /// <exception cref="ItemCreationFailureException"></exception>
        /// <returns></returns>
        public UserToken.Classifieds.ListingsCreator.Models.Response CreateBuyListing(
            string fullItemName, string qualityIndex, string currency, decimal price, string message)
        {
            var item = new ListingItem(fullItemName, qualityIndex);
            var currencies = new Dictionary<string, decimal>
            {
                { currency, price }
            };
            var listings = new List<InputListing>()
            {
                new InputListing(0, currencies, message, null, item)
            };

            if (listings.Count > 0)
            {
                var uri = this.BuildUri(BaseUris.ClassifiedsCreate, this.AccessToken);
                return UserListingsHandler.CreateListings(new Input(listings), uri);
            }

            throw new ItemCreationFailureException($"Failed to create listing for item - {fullItemName}");
        }

        /// <summary>
        /// Fetches a user's inventory.
        /// </summary>
        /// <param name="steamid64"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public SteamUser.UserInventory.Models.Response GetUserInventory(string steamid64)
        {
            var userInventoryUri =
            $"http://steamcommunity.com/inventory/{steamid64}/{BaseUris.AppId}/2?l=english&count=5000";
            return InventoryHandler.DownloadUserInventory(userInventoryUri);
        }

        /// <summary>
        /// Fetches the current user's inventory.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public SteamUser.UserInventory.Models.Response GetOwnInventory()
        {
            this.userInventory = this.GetUserInventory(this.SteamId64);
            return this.userInventory;
        }

        /// <summary>
        /// Searches for an item in the user's inventory and returns its Asset and Description models.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        /// <exception cref="ItemNotFoundException"></exception>
        /// <exception cref="InventoryNullException"></exception>
        public InventoryItem GetItemFromInventory(string itemName)
        {
            if (this.userInventory == null)
            {
                throw new InventoryNullException(Messages.InventoryNullError);
            }

            var itemAsset = InventoryHandler.GetItemAsset(this.userInventory, itemName);
            var itemDescription = InventoryHandler.GetItemDescription(this.userInventory, itemName);

            if (itemAsset == null || itemDescription == null)
            {
                throw new ItemNotFoundException($"{Messages.ItemNotFoundError} Item name - {itemName}");
            }

            return new InventoryItem(itemAsset, itemDescription);
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
