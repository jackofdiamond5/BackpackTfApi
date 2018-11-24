using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.Models
{
    public class Response
    {
        [JsonProperty("total")]
        public int Total { get; internal set; }

        [JsonProperty("skip")]
        public int Skip { get; internal set; }

        [JsonProperty("page_size")]
        public int PageSize { get; internal set; }

        [JsonProperty("buy")]
        public Intent Buy { get; internal set; }

        [JsonProperty("sell")]
        public Intent Sell { get; internal set; }
    }
}
