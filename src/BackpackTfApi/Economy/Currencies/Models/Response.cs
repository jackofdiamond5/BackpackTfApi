using System.Collections.Generic;

using Newtonsoft.Json;

namespace BackpackTfApi.Economy.Currencies.Models
{
    public class Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("currencies")]
        public IDictionary<string, CurrencyType> Currencies { get; set; }

        internal bool IsInitialized
         => this.Message != null && this.Name != null && this.Url != null && this.Currencies != null;
    }
}
