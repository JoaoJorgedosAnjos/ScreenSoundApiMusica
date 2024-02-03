using ScreenSoundApiMusica.Models;

namespace ScreenSoundApiMusica.Filters;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas1)
    {
        var artistasOrdenados = musicas1.OrderBy(musica => musica.Artista);
        foreach (var item in artistasOrdenados)
        {
            Console.WriteLine(item.Artista);
        }
    }
}