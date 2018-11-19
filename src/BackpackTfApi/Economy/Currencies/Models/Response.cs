using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Currencies.Models
{
    public class Response
    {
        [JsonProperty("message")]
        public string Message { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("url")]
        public string Url { get; internal set; }

        [JsonProperty("currencies")]
        public IReadOnlyDictionary<string, CurrencyType> Currencies { get; internal set; }

        internal bool IsInitialized
         => this.Message != null && this.Name != null && this.Url != null && this.Currencies != null;
    }
}
