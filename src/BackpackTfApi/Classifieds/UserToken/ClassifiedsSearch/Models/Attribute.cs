using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ClassifiedsSearch.Models
{
    public class Attribute
    {
        [JsonProperty("defindex")]
        public int Defindex { get; internal set; }

        [JsonProperty("value")]
        public long Value { get; internal set; }

        [JsonProperty("float_value")]
        public decimal? FloatValue { get; internal set; }
    }
}
