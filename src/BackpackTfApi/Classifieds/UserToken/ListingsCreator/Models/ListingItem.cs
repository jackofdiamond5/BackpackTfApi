using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class ListingItem
    {
        public ListingItem(string itemName, string quality, string craftable = null, int? priceindex = null)
        {
            this.ItemName = itemName;
            this.Quality = quality;
            this.Craftable = craftable;
            this.PriceIndex = priceindex;
        }

        [JsonProperty("quality")]
        public string Quality { get; internal set; }

        [JsonProperty("item_name")]
        public string ItemName { get; internal set; }

        [JsonProperty("craftable")]
        public string Craftable { get; internal set; }

        [JsonProperty("priceindex")]
        public int? PriceIndex { get; internal set; }
    }
}
