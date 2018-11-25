using BackpackTfApi.Classifieds.Templates;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.Models
{
    public class ClassifiedSearchListing : Listing
    {
        [JsonProperty("steamid")]
        public string SteamId { get; internal set; }

        [JsonProperty("appid")]
        public int AppId { get; internal set; }
        
        [JsonProperty("created")]
        public long Created { get; internal set; }

        [JsonProperty("bump")]
        public long Bump { get; internal set; }
    }
}
