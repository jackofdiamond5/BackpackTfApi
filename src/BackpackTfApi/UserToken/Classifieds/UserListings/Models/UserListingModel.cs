using Newtonsoft.Json;

using BackpackTfApi.UserToken.Classifieds.Templates;

namespace BackpackTfApi.UserToken.Classifieds.UserListings.Models
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
