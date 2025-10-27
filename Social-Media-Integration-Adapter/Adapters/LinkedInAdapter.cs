using SocialMediaIntegration.Interfaces;
using SocialMediaIntegration.Models;
using SocialMediaIntegration.SimulatedApis;

namespace SocialMediaIntegration.Adapters
{
    // Adapter para o LinkedIn
    public class LinkedInAdapter : ISocialMediaAdapter
    {
        private readonly LinkedInApi _linkedInApi = new LinkedInApi();

        public PostResult Post(Content content)
        {
            if (string.IsNullOrEmpty(content.ImageUrl))
            {
                return new PostResult { Success = false, Message = "LinkedIn posts require an image." };
            }
            
            // "Traduz" nossa chamada para a da API do LinkedIn
            var postId = _linkedInApi.ShareArticle(content.Author, content.Text, content.ImageUrl);

            // "Traduz" a resposta para o nosso modelo unificado
            return new PostResult
            {
                Success = true,
                PostId = postId,
                Message = "Article shared on LinkedIn.",
                Stats = new PostStatistics { Likes = 0, Shares = 0 }
            };
        }
    }
}