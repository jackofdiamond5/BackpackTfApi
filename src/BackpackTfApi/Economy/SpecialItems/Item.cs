using Newtonsoft.Json;

namespace BackpackTfApi.Economy.SpecialItems
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("item_name")]
        public string ItemName { get; internal set; }

        [JsonProperty("defindex")]
        public int Defindex { get; internal set; }

        [JsonProperty("item_class")]
        public string ItemClass { get; internal set; }

        [JsonProperty("item_type_name")]
        public string ItemTypeName { get; internal set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; internal set; }

        [JsonProperty("item_quality")]
        public int ItemQuality { get; internal set; }

        [JsonProperty("min_ilevel")]
        public int MinILevel { get; internal set; }

        [JsonProperty("max_ilevel")]
        public int MaxILevel { get; internal set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; internal set; }

        [JsonProperty("image_url_large")]
        public string ImageUrlLarge { get; internal set; }

        [JsonProperty("appid")]
        public int AppId { get; internal set; }
    }
}
