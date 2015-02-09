using TweetSharp;

namespace WoodenHorse
{
    public class TwitterService : ITweets
    {
        private const string AccessToken = "94355514-Z94MguSiz1oAZOeW1fZE3W1Lll2r0QAaylSMCANPr";
        private const string AccessTokenSecret = "Ia4EiYjOMJRRnkVPIksx6h6N56LdZiINqKzZlpfMEfZ1u";
        private const string ConsumerSecret = "L4CRZ6Kj7CEfyZrDZUbheb173gvcFVHuRjdtyLT4kYuhM05z4u";
        private const string ConsumerKey = "zBllixFA9UnBhWvazyxqGweCX";

        public string NextTweet()
        {
            var service = new TweetSharp.TwitterService(ConsumerKey, ConsumerSecret);
            service.AuthenticateWith(AccessToken, AccessTokenSecret);

            var tweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions
            {
                ScreenName = "Lanternman1"
            });

            foreach (var tweet in tweets)
            {
                return tweet.Text;
            }
            return string.Empty;
        }
    }
}