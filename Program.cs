using System.Text.Json;
using ScreenSoundApiMusica.Filters;
using ScreenSoundApiMusica.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas,"Red Hot Chili Peppers");
        LinqFilter.FiltrarMusicasComMesmaTonalidade(musicas, "C#");


        // var musicasPreferidasJoao = new MusicasPreferidas("João");
        // musicasPreferidasJoao.AdicionarMusicasFavoritas(musicas[0]);
        // musicasPreferidasJoao.AdicionarMusicasFavoritas(musicas[15]);
        // musicasPreferidasJoao.AdicionarMusicasFavoritas(musicas[190]);
        // musicasPreferidasJoao.AdicionarMusicasFavoritas(musicas[1540]);

        // musicasPreferidasJoao.ExibirMusicasFavoritas();

        // var musicasPreferidasDaniela = new MusicasPreferidas("Daniela");

        // musicasPreferidasDaniela.AdicionarMusicasFavoritas(musicas[10]);
        // musicasPreferidasDaniela.AdicionarMusicasFavoritas(musicas[195]);
        // musicasPreferidasDaniela.AdicionarMusicasFavoritas(musicas[15]);
        // musicasPreferidasDaniela.AdicionarMusicasFavoritas(musicas[120]);

        // musicasPreferidasDaniela.ExibirMusicasFavoritas();

        // musicasPreferidasDaniela.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}


