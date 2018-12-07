using System.Net;
using Newtonsoft.Json;

using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;
using System.Collections.Generic;

namespace BackpackTfApi.Classifieds.UserToken.Utilities
{
    public static class ListingsCreator
    {
        public static Response CreateListings(Input inputData, string uri)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var response = client.UploadString(uri, JsonConvert.SerializeObject(inputData));
                    return OutputData.FromJson(response);
                }
                catch (WebException ex)
                {
                    // TODO
                    return null;
                }
            }
        }
    }
}
