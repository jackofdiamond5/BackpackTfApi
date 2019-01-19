using System;
using System.Net;
using System.Linq;

using BackpackTfApi.Static;
using BackpackTfApi.Exceptions;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public static class InventoryHandler
    {
        /// <summary>
        /// Fetches the user inventory JSON object from Steam and converts it to a .NET type.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static Response DownloadUserInventory(string uri)
        {
            using (var client = new WebClient())
                return UserInventoryData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Gets the Description object of the targeted item in the user's inventory.
        /// </summary>
        /// <param name="steamInventory"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public static Description GetItemDescription(Response steamInventory, string itemName)
        {
            try
            {
                return steamInventory.Descriptions.Where(d => d.Name == itemName).First();
            }
            catch (InvalidOperationException)
            {
                throw new ItemNotFoundException($"{Messages.ItemNotFoundError} Item name - {itemName}");
            }
        }

        /// <summary>
        /// Gets the Asset object of the targeted item in the user's inventory.
        /// </summary>
        /// <param name="steamInventory"></param>
        /// <param name="itemName"></param>
        /// <exception cref="InvalidOperationException"></exception>
        /// <returns></returns>
        public static Asset GetItemAsset(Response steamInventory, string itemName)
        {
            var targetItem = GetItemDescription(steamInventory, itemName);
            return steamInventory.Assets.Where(a => a.InstanceId == targetItem.InstanceId).First();
        }
    }
}
