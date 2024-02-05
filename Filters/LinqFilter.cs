using ScreenSoundApiMusica.Models;

namespace ScreenSoundApiMusica.Filters;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musicas => musicas.Artista).Distinct();

        Console.WriteLine($"Exibindo os artistas por gênero musical => {genero}");
        foreach (var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine(artista);
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarMusicasComMesmaTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasComMesmaTonalidade = musicas.Where(musica => musica.Tonalidade == tonalidade).DistinctBy(musica => musica.Nome);
        Console.WriteLine("Músicas com mesma tonalidade");
        foreach (var musica in musicasComMesmaTonalidade)
        {
            Console.WriteLine($"- {musica.Nome} tonalidade {musica.Tonalidade}");
        } 
    }
}



