using Newtonsoft.Json;

namespace BackpackTfApi.Economy.SpecialItems
{
    public class SpecialitemsData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static SpecialitemsData FromJson(string json) => JsonConvert.DeserializeObject<SpecialitemsData>(json);
    }
}
