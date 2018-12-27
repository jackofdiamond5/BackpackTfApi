using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.ClassifiedsSearch.Models
{
    public class ClassifiedsData
    {
        public Response Response { get; internal set; }

        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json);
    }
}
