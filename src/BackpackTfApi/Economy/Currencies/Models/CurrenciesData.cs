using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Currencies.Models
{
    public partial class CurrenciesData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static CurrenciesData FromJson(string json) => JsonConvert.DeserializeObject<CurrenciesData>(json);
    }
}
