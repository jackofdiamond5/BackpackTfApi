using Newtonsoft.Json;
using System.Collections.Generic;

namespace BackpackTfApi.Classifieds.UserToken.Models
{
    public class Item
    {
        [JsonProperty("defindex")]
        public int Defindex { get; internal set; }

        [JsonProperty("quality")]
        public int Quality { get; internal set; }

        [JsonProperty("attributes")]
        public IReadOnlyCollection<Attribute> Attributes { get; internal set; }

        [JsonProperty("user-id")]
        public string UserId { get; internal set; }

        [JsonProperty("quantity")]
        public string Quantity { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}
