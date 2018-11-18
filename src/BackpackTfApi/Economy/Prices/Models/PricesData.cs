using Newtonsoft.Json;

using BackpackTfApi.Economy.Prices.Static;

namespace BackpackTfApi.Economy.Prices.Models
{
    public partial class PricesData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static PricesData FromJson(string json) => JsonConvert.DeserializeObject<PricesData>(json, Converter.Settings);
    }
}
