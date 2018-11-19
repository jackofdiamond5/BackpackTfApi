using Newtonsoft.Json;

namespace BackpackTfApi.Economy.PriceHistory.Models
{
    public class PriceHistoryData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static PriceHistoryData FromJson(string json) => JsonConvert.DeserializeObject<PriceHistoryData>(json);
    }
}
