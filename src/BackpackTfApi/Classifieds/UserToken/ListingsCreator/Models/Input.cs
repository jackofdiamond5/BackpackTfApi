using System.Collections.Generic;

using Newtonsoft.Json;

using BackpackTfApi.Classifieds.Templates;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Input
    {
        [JsonProperty("token")]
        public string Token { get; internal set; }

        [JsonProperty("listings")]
        public ICollection<Listing> Listings { get; internal set; }
    }
}
