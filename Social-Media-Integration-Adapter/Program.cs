using SocialMediaIntegration.Core;
using SocialMediaIntegration.Factories;
using SocialMediaIntegration.Models;
using SocialMediaIntegration.Strategies;

// --- CONFIGURAÇÃO (simulando configuração por ambiente) ---
var platformsToPost = new[] { "twitter", "linkedin" };

// --- CRIAÇÃO DO CONTEÚDO ---
var myContent = new Content
{
    Author = "Gesonel Banks",
    Text = "Fique rico no Gansinho 🤑🤑🤑💰💰💰",
    ImageUrl = "https://img.freepik.com/psd-gratuitas/3d-realistas-notas-de-dinheiro-do-brasil-moeda-real_314999-3810.jpg?semt=ais_hybrid&w=740&q=80"
};

// --- INICIALIZAÇÃO DO GERENCIADOR COM UMA ESTRATÉGIA PADRÃO ---
var manager = new SocialMediaManager(new SimpleTextPostStrategy());

Console.WriteLine("--- Starting Social Media Publishing Job ---");

foreach (var platform in platformsToPost)
{
    try
    {
        Console.WriteLine($"\nProcessing platform: {platform.ToUpper()}");

        // 1. FACTORY: Cria o adapter correto dinamicamente
        var adapter = SocialMediaAdapterFactory.CreateAdapter(platform);

        // 2. STRATEGY & ADAPTER: O manager usa a estratégia atual para publicar através do adapter
        var result = manager.Publish(adapter, myContent);

        // 3. RESPOSTA UNIFICADA: Exibe o resultado padronizado
        if (result.Success)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"SUCCESS! Post ID on {platform}: {result.PostId}");
            Console.WriteLine($"Message: {result.Message}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED to post on {platform}. Reason: {result.Message}");
            Console.ResetColor();
        }
    }
    catch (NotSupportedException ex)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
}

Console.WriteLine("\n--- Job Finished ---");