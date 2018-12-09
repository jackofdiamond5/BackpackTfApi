using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.Users.Models
{
    public class UsersData
    {
        [JsonProperty("users")]
        public IReadOnlyDictionary<string, User> Users { get; internal set; }

        public static UsersData FromJson(string json) => JsonConvert.DeserializeObject<UsersData>(json);
    }
}
