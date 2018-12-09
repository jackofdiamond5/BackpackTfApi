using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.Users.Models
{
    public class Slots
    {
        [JsonProperty("used")]
        public int Used { get; internal set; }

        [JsonProperty("total")]
        public int Total { get; internal set; }
    }
}
