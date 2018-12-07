using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Input
    {
        public Input(string token, ICollection<InputListing> listings)
        {
            this.Token = token;
            this.Listings = listings;
        }

        [JsonProperty("token")]
        public string Token { get; internal set; }

        [JsonProperty("listings")]
        public ICollection<InputListing> Listings { get; internal set; }
    }
}
