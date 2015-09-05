using Newtonsoft.Json;

namespace HttpClientDemo.Controllers
{
   public class Tweets
    {
        public Tweet[] results;
    }
   public class Tweet
    {
        [JsonProperty("from_user")]
        public string UserName { get; set; }
        [JsonProperty("text")]
        public string TweetText { get; set; }
    }
}

