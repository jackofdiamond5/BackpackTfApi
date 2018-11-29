using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class OutputData
    {
        public Output Response { get; internal set; }

        public static Output FromJson(string json) => JsonConvert.DeserializeObject<Output>(json);
    }
}
