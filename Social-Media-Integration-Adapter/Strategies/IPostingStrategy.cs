using SocialMediaIntegration.Interfaces;
using SocialMediaIntegration.Models;

namespace SocialMediaIntegration.Strategies
{
    // Interface para o padrão Strategy
    public interface IPostingStrategy
    {
        PostResult Execute(ISocialMediaAdapter adapter, Content content);
    }
}