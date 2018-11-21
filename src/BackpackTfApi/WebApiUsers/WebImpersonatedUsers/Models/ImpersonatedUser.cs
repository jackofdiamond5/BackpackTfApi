using Newtonsoft.Json;

namespace BackpackTfApi.WebApiUsers.WebImpersonatedUsers.Models
{
    public class ImpersonatedUser
    {
        [JsonProperty("steamid")]
        public long SteamId { get; internal set; }

        [JsonProperty("personaname")]
        public string PersonName { get; internal set; }

        [JsonProperty("avatar")]
        public string  Avatar { get; internal set; }
    }
}
