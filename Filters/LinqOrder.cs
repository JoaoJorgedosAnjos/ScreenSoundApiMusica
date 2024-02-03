using ScreenSoundApiMusica.Models;

namespace ScreenSoundApiMusica.Filters;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas1)
    {
        var artistasOrdenados = musicas1.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct();
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}