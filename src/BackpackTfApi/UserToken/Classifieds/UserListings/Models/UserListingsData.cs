using Newtonsoft.Json;

namespace BackpackTfApi.UserToken.Classifieds.UserListings.Models
{
    public class UserListingsData
    {
        public Response Response { get; internal set; }

        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json);
    }
}
