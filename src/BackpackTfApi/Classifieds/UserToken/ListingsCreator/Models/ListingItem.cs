using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class ListingItem
    {
        public ListingItem(string quality, string itemName, string craftable, int? priceindex = null)
        {
            this.Quality = quality;
            this.ItemName = itemName;
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
