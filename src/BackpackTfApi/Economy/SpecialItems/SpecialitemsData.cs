using Newtonsoft.Json;

namespace BackpackTfApi.Economy.SpecialItems
{
    public class SpecialItemsData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static SpecialItemsData FromJson(string json) => JsonConvert.DeserializeObject<SpecialItemsData>(json);
    }
}
