using System.IO;
using System.Net;

using BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models;

namespace BackpackTfApi.Classifieds.UserToken.Utilities
{
    public static class ListingsCreator
    {
        public static Response CreateSellListings(Input inputData, string uri)
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

        public static Response CreateBuyListings(Input inputdata, string uri)
        {
            return null;
        }
    }
}
