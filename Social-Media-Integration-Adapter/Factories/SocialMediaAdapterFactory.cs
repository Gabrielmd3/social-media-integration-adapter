using SocialMediaIntegration.Adapters;
using SocialMediaIntegration.Interfaces;

namespace SocialMediaIntegration.Factories
{
    // TAREFA 3: Factory para criar o adapter correto dinamicamente
    public static class SocialMediaAdapterFactory
    {
        public static ISocialMediaAdapter CreateAdapter(string platform)
        {
            return platform.ToLower() switch
            {
                "twitter" => new TwitterAdapter(),
                "linkedin" => new LinkedInAdapter(),
                // Adicione outros casos aqui (ex: "tiktok", "instagram")
                _ => throw new NotSupportedException($"Platform '{platform}' is not supported.")
            };
        }
    }
}