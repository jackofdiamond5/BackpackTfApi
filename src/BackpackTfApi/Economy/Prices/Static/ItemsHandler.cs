using System;
using System.Net;

using BackpackTfApi.Static;
using BackpackTfApi.Economy.Prices.Models;

namespace BackpackTfApi.Economy.Prices.Static
{
    public static class ItemsHandler
    {
        /// <summary>
        /// Fetches the prices JSON object from Backpack.TF and converts it to a .NET type.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static PricesData DownloadPrices(string uri)
        {
            using (var client = new WebClient())
                return PricesData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Fetches a tradable item from the response object that matches the provided name and quality index.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="itemName"></param>
        /// <param name="qualityIndex"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Tradable GetTradableItem(Response response, string itemName, string qualityIndex)
        {
            var itemData = GetItemData(response, itemName, qualityIndex);
            return itemData.Tradable;
        }

        /// <summary>
        /// Fetches a non-tradable item from the response object that matches the provided name and quality index.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="itemName"></param>
        /// <param name="qualityIndex"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static NonTradable GetNonTradableItem(Response response, string itemName, string qualityIndex)
        {
            var itemData = GetItemData(response, itemName, qualityIndex);
            return itemData.NonTradable;
        }

        /// <summary>
        /// Fetches an item from the response object that matches the provided name.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Item GetItemByName(Response response, string itemName)
        {
            if (response.Items.ContainsKey(itemName))
            {
                return response.Items[itemName];
            }

            throw new InvalidOperationException(Messages.ItemNotFoundErrorMessage);
        }

        private static Price GetItemData(Response response, string itemName, string qualityIndex)
        {
            var item = GetItemByName(response, itemName);
            if (item.Prices.ContainsKey(qualityIndex))
            {
                return item.Prices[qualityIndex];
            }

            throw new InvalidOperationException(Messages.ItemNotFoundErrorMessage);
        }
    }
}
