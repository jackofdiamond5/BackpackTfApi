using Newtonsoft.Json;

using System.Collections.Generic;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Response
    {
        [JsonProperty("message")]
        public string Message { get; internal set; }

        [JsonProperty("listings")]
        public IReadOnlyDictionary<string, Result> Result { get; internal set; }
    }
}
