using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Output
    {
        [JsonProperty("message")]
        public string Message { get; internal set; }

        [JsonProperty("listings")]
        public IReadOnlyDictionary<long, Result> Result { get; internal set; }
    }
}
