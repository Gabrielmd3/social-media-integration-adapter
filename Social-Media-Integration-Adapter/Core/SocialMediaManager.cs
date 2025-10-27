using SocialMediaIntegration.Interfaces;
using SocialMediaIntegration.Models;
using SocialMediaIntegration.Strategies;

namespace SocialMediaIntegration.Core
{
    // Nosso gerenciador unificado (o "Client")
    public class SocialMediaManager
    {
        private IPostingStrategy _strategy;

        public SocialMediaManager(IPostingStrategy defaultStrategy)
        {
            _strategy = defaultStrategy;
        }

        public void SetStrategy(IPostingStrategy strategy)
        {
            Console.WriteLine($"\n-> Strategy changed to: {strategy.GetType().Name}");
            _strategy = strategy;
        }

        public PostResult Publish(ISocialMediaAdapter adapter, Content content)
        {
            // Delega a execução para a estratégia atual
            return _strategy.Execute(adapter, content);
        }
    }
}