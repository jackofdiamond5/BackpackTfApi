using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Input
    {
        public Input(ICollection<InputListing> listings)
        {
            this.Listings = listings;
        }

        [JsonProperty("listings")]
        public ICollection<InputListing> Listings { get; internal set; }

        public string ToJson() => JsonConvert.SerializeObject(this);
    }
}
