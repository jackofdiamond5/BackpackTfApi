using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public class Response
    {
        /// <summary>
        /// Contains all item asset objects.
        /// </summary>
        [JsonProperty("assets")]
        public IReadOnlyCollection<Asset> Assets { get; internal set; }

        /// <summary>
        /// Contains all item description objects.
        /// </summary>
        [JsonProperty("descriptions")]
        public IReadOnlyCollection<Description> Descriptions { get; internal set; }

        /// <summary>
        /// The total amount of items in the user's inventory.
        /// </summary>
        [JsonProperty("total_inventory_count")]
        public int TotalInventoryCount { get; internal set; }

        /// <summary>
        /// Value is 1 if the user's iventory was fetched and less than 1 otherwise.
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; internal set; }

        [JsonProperty("rwgrsn")]
        public int Rwgrsn { get; internal set; }

    }
}
