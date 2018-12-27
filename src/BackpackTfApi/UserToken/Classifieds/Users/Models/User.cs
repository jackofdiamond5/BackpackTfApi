using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.Users.Models
{
    public class User
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; internal set; }

        [JsonProperty("last_online")]
        public long LastOnline { get; internal set; }

        [JsonProperty("donated")]
        public double Donated { get; internal set; }

        [JsonProperty("inventory")]
        public Dictionary<string, Inventory> Inventory { get; internal set; }
    }
}
