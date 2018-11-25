using Newtonsoft.Json;

namespace BackpackTfApi.Classifieds.UserToken.UserListings.Models
{
    public class UserListingsData
    {
        public Response Response { get; internal set; }

        public Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json);
    }
}
