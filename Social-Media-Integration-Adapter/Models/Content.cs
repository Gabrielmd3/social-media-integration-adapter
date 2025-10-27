namespace SocialMediaIntegration.Models
{
    // Modelo de dados unificado para o conteúdo a ser publicado
    public class Content
    {
        public string Author { get; set; } = string.Empty; // Corrigido
        public string Text { get; set; } = string.Empty;   // Corrigido
        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }
    }
}