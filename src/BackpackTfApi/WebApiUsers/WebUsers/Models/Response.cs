using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.WebApiUsers.WebUsers.Models
{
    public class Response
    {
        [JsonProperty("success")]
        public string Success { get; internal set; }

        [JsonProperty("current_time")]
        public long CurrentTime { get; internal set; }

        [JsonProperty("players")]
        public IReadOnlyDictionary<string, WebUser> Players { get; internal set; }
    }
}
