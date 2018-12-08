using Newtonsoft.Json;

using BackpackTfApi.Classifieds.Templates;

namespace BackpackTfApi.Classifieds.UserToken.UserListings.Models
{
    public class UserListingModel : Listing
    {
        [JsonProperty("appid")]
        public int AppId { get; internal set; }

        [JsonProperty("bump", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bump { get; internal set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; internal set; }
    }
}
