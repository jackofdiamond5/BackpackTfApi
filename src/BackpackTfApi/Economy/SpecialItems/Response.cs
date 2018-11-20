using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.SpecialItems
{
    public class Response
    {
        [JsonProperty("success")]
        public int Success { get; internal set; }

        [JsonProperty("current_time")]
        public long CurrentTime { get; internal set; }

        [JsonProperty("items")]
        public IReadOnlyCollection<Item> Items { get; internal set; }
    }
}
