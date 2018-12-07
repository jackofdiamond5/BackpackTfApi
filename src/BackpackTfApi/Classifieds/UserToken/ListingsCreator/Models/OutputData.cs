﻿using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class OutputData
    {
        public Response Response { get; internal set; }

        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json);
    }
}
