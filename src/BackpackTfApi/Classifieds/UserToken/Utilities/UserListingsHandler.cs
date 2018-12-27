using System;
using System.IO;
using System.Net;
using System.Text;

using BackpackTfApi.Classifieds.UserToken.UserListings.Models;
using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;

namespace BackpackTfApi.Classifieds.UserToken.Utilities
{
    public static class UserListingsHandler
    {
        /// <summary>
        /// Creates a new buy or sell listings.
        /// </summary>
        /// <param name="inputData"></param>
        /// <param name="uri"></param>
        /// <returns></returns> 
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="IOException"></exception>
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

        /// <summary>
        /// Fetches the listings of a specific user and converts them to a .NET type.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="intent"></param>
        /// <param name="inactive"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="WebException"></exception>
        /// <exception cref="NotSupportedException"></exception>
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
