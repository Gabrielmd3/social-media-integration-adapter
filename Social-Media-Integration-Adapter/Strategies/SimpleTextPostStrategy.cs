using SocialMediaIntegration.Interfaces;
using SocialMediaIntegration.Models;

namespace SocialMediaIntegration.Strategies
{
    // Estratégia simples: apenas posta o conteúdo de texto.
    public class SimpleTextPostStrategy : IPostingStrategy
    {
        public PostResult Execute(ISocialMediaAdapter adapter, Content content)
        {
            Console.WriteLine("--- Using Simple Text Post Strategy ---");
            if (string.IsNullOrWhiteSpace(content.Text))
            {
                return new PostResult { Success = false, Message = "Content text cannot be empty." };
            }
            return adapter.Post(content);
        }
    }
}