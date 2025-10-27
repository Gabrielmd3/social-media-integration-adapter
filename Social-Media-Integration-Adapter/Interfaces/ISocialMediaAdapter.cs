using SocialMediaIntegration.Models;

namespace SocialMediaIntegration.Interfaces
{
    // TAREFA 1: A interface unificada que nosso sistema usará (o "Target")
    public interface ISocialMediaAdapter
    {
        PostResult Post(Content content);
    }
}