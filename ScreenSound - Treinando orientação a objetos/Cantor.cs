﻿class Cantor
{
    private List<Album> albums = new List<Album>();

    public Cantor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}