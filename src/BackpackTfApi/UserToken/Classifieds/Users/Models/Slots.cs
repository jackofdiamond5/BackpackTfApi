using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.Users.Models
{
    public class Slots
    {
        [JsonProperty("used")]
        public int Used { get; internal set; }

        [JsonProperty("total")]
        public int Total { get; internal set; }
    }
}
