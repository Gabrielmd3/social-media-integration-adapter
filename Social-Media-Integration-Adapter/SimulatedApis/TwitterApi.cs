namespace SocialMediaIntegration.SimulatedApis
{
    // API simulada do Twitter com seus próprios métodos
    public class TwitterApi
    {
        public (bool success, string tweetId) SendTweet(string user, string text)
        {
            Console.WriteLine($"[Twitter API] User '{user}' tweeted: '{text}'");
            return (true, Guid.NewGuid().ToString());
        }
    }
}