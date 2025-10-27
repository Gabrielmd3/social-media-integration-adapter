namespace SocialMediaIntegration.Models
{
    // Modelo de dados para a resposta unificada após uma publicação
    public class PostResult
    {
        public bool Success { get; set; }
        public string PostId { get; set; } = string.Empty;    // Corrigido
        public string Message { get; set; } = string.Empty;   // Corrigido
        public PostStatistics Stats { get; set; } = new();      // Corrigido
    }

    public class PostStatistics
    {
        public int Likes { get; set; }
        public int Shares { get; set; }
    }
}