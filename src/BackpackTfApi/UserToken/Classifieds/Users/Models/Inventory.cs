using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.Users.Models
{
    public class Inventory
    {
        [JsonProperty("ranking", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ranking { get; internal set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Value { get; internal set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public long? Updated { get; internal set; }

        [JsonProperty("metal")]
        public decimal Metal { get; internal set; }

        [JsonProperty("keys")]
        public decimal Keys { get; internal set; }

        [JsonProperty("slots")]
        public Slots Slots { get; internal set; }
    }
}
