using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public class UserInventoryData
    {
        public Response Response { get; internal set; }

        /// <summary>
        /// Converts the JSON response string containing the user's inventory to a .NET type.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json);
    }
}
