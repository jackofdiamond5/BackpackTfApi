using Newtonsoft.Json;

using BackpackTfApi.Economy.Prices.Models;

namespace BackpackTfApi.Economy.Prices.Static
{
    public static class Serialize
    {
        public static string ToJson(this PricesData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
