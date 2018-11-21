using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.WebApiUsers.WebImpersonatedUsers.Models
{
    public class ImpersonatedUsersData
    {
        [JsonProperty("results")]
        public IReadOnlyCollection<ImpersonatedUser> Results { get; internal set; }

        [JsonProperty("total")]
        public int Total { get; internal set; }

        public static ImpersonatedUsersData FromJson(string json) => JsonConvert.DeserializeObject<ImpersonatedUsersData>(json);
    }
}
