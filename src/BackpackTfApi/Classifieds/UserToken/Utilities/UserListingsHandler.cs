using System.IO;
using System.Net;
using System.Text;

using BackpackTfApi.Classifieds.UserToken.UserListings.Models;
using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;

namespace BackpackTfApi.Classifieds.UserToken.Utilities
{
    public static class UserListingsHandler
    {
        public static ListingsCreator.Models.Response CreateListings(Input inputData, string uri)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(inputData.ToJson());
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var httpResponseStream = httpResponse.GetResponseStream();
            using (var streamReader = new StreamReader(httpResponseStream))
            {
                return OutputData.FromJson(streamReader.ReadToEnd());
            }
        }

        public static UserListings.Models.Response GetUserListings(string uri, int? intent = null, int? inactive = null)
        {
            var uriBuilder = new StringBuilder();
            uriBuilder.Append(uri);

            if (intent != null)
            {
                uriBuilder.Append($"&intent={intent}");
            } 
            if (inactive != null)
            {
                uriBuilder.Append($"&inactive={inactive}");
            }

            using (var client = new WebClient())
                return UserListingsData.FromJson(client.DownloadString(uriBuilder.ToString()));
        }
    }
}
