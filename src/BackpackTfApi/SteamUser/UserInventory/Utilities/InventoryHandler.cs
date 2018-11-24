using System.Net;
using System.Linq;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    // https://github.com/babelshift/SteamWebAPI2
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
            => steamInventory.Descriptions.Where(d => d.Name == itemName).First();

        /// <summary>
        /// Gets the Asset object of the targeted item in the user's inventory.
        /// </summary>
        /// <param name="steamInventory"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public static Asset GetItemAsset(Response steamInventory, string itemName)
        {
            var targetItem = GetItemDescription(steamInventory, itemName);
            return steamInventory.Assets.Where(a => a.InstanceId == targetItem.InstanceId).First();
        }
    }
}
