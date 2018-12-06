using System.Net;
using Newtonsoft.Json;

using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;

namespace BackpackTfApi.Classifieds.UserToken.Utilities
{
    public static class ListingsCreator
    {
        public static Output CreateListing(Input input, string uri)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var response = client.UploadString(uri, JsonConvert.SerializeObject(input));
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
