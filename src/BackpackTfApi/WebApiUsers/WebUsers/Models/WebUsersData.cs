using Newtonsoft.Json;
 
namespace BackpackTfApi.WebApiUsers.WebUsers.Models
{
    public class WebUsersData
    {
        [JsonProperty("response")]
        public Response Response { get; internal set; }

        public static WebUsersData FromJson(string json) => JsonConvert.DeserializeObject<WebUsersData>(json);
    }
}
