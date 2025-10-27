namespace SocialMediaIntegration.SimulatedApis
{
    // API simulada do LinkedIn com métodos diferentes
    public class LinkedInApi
    {
        public string ShareArticle(string profileId, string content, string imageUrl)
        {
            Console.WriteLine($"[LinkedIn API] Profile '{profileId}' shared an article with image '{imageUrl}'");
            return $"urn:li:share:{new Random().Next(10000, 99999)}";
        }
    }
}