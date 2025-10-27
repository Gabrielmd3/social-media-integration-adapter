using SocialMediaIntegration.Interfaces;
using SocialMediaIntegration.Models;
using SocialMediaIntegration.SimulatedApis;

namespace SocialMediaIntegration.Adapters
{
    // Adapter para o Twitter
    public class TwitterAdapter : ISocialMediaAdapter
    {
        private readonly TwitterApi _twitterApi = new TwitterApi();

        public PostResult Post(Content content)
        {
            // "Traduz" nossa chamada unificada para a chamada específica da API do Twitter
            var (success, tweetId) = _twitterApi.SendTweet(content.Author, content.Text);

            // TAREFA 2: "Traduz" a resposta específica para nossa resposta unificada
            return new PostResult
            {
                Success = success,
                PostId = tweetId,
                Message = "Tweet published successfully.",
                Stats = new PostStatistics { Likes = 0, Shares = 0 } // Stats iniciais
            };
        }
    }
}