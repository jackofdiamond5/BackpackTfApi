using BackpackTfApi.Economy.Currencies.Models;
using System;

using BackpackTfApi.Static;

namespace BackpackTfApi.Economy.Currencies.Static
{
    public class CurrenciesHandler
    {
        public static CurrencyType GetCurrencyData(string name, Response response)
        {
            if (response.Currencies.ContainsKey(name))
            {
                return response.Currencies[name];                
            }

            throw new InvalidOperationException(Messages.CurrencyNotFoundError);
        }
    }
}
