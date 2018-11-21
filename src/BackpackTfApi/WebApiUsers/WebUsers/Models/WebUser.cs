using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.WebApiUsers.WebUsers.Models
{
    public class WebUser
    {
        [JsonProperty("steamid")]
        public long SteamId { get; internal set; }

        [JsonProperty("success")]
        public int Success { get; internal set; }

        [JsonProperty("backpack_value")]
        public IReadOnlyDictionary<string, decimal> BackpackValue { get; internal set; }

        [JsonProperty("backpack_update")]
        public IReadOnlyDictionary<string, long> BackpackUpdate { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("backpack_tf_trust")]
        public IReadOnlyDictionary<string, int> BackpackTfTrust { get; internal set; }
    }
}
