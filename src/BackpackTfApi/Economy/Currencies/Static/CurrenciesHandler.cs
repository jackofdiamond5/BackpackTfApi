using System;
using System.Net;

using BackpackTfApi.Static;
using BackpackTfApi.Economy.Currencies.Models;

namespace BackpackTfApi.Economy.Currencies.Static
{
    public class CurrenciesHandler
    {
        /// <summary>
        /// Fetch currencies data from BackpackTF
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <exception cref="WebException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public static CurrenciesData DownloadCurrencyData(string uri)
        {
            using (var client = new WebClient())
                return CurrenciesData.FromJson(client.DownloadString(uri));
        }

        /// <summary>
        /// Get information for the specified currency.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static CurrencyType GetCurrencyData(Response response, string name)
        {
            if (!response.IsInitialized)
            {
                throw new ArgumentNullException(Messages.ResponseNullError);
            }
            if (response.Currencies.ContainsKey(name))
            {
                return response.Currencies[name];                
            }

            throw new InvalidOperationException(Messages.CurrencyNotFoundError);
        }
    }
}
