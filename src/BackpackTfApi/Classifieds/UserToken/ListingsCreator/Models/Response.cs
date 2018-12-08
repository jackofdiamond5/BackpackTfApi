using Newtonsoft.Json;

using System.Collections.Generic;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Response
    {
        [JsonProperty("listings")]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> Result { get; internal set; }
    }
}
