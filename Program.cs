using System.Text.Json;
using ScreenSoundApiMusica.Filters;
using ScreenSoundApiMusica.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // musicas[0].ExibirDetalhesDaMusica();
        // foreach (var musica in musicas)
        // {
        //     musica.ExibirDetalhesDaMusica();
        //     Console.WriteLine("");
        // }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}


