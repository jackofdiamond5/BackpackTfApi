using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BackpackTfApi.Economy.PriceHistory.Models
{
    public class Response
    {
        [JsonProperty("success")]
        public int Success { get; internal set; }

        [JsonProperty("history")]
        public ICollection<History> History { get; internal set; }
    }
}
