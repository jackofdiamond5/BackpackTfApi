using System;
using System.Net;
using System.Collections.Generic;

using BackpackTfApi.UserToken.Classifieds.Users.Models;

namespace BackpackTfApi.UserToken.Classifieds.Utilities
{
    public static class UsersDataHandler
    {
        /// <summary>
        /// Downloads the users' data JSON and converts it to a .NET type.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public static UsersData FetchUserData(string uri)
        {
            using (var client = new WebClient())
                return UsersData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Searches the users data and returns a user's inventory for a specified AppId.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="userId"></param>
        /// <param name="appid"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public static Inventory GetUserInventoryForApp(UsersData users, string userId, string appid)
        {
            if (!users.Users.ContainsKey(userId))
                throw new KeyNotFoundException("Cannot find user with the specified SteamId64.");

            if (!users.Users[userId].Inventory.ContainsKey(appid))
                throw new KeyNotFoundException("Cannot find an inventory for the specified AppId");

            return users.Users[userId].Inventory[appid];
        }
    }
}
