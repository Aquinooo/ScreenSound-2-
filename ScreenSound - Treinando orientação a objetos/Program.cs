Cantor veigh = new Cantor("Veigh");

Album albumDoVeigh = new Album("Dos prédios");

Musica musica1 = new Musica(veigh, "Novo balanço")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(veigh, "Foto da unha")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoVeigh.AdicionarMusica(musica1);
albumDoVeigh.AdicionarMusica(musica2);
veigh.AdicionarAlbum(albumDoVeigh);

musica1.ExibirFichaTecnica();
Console.WriteLine("*******************");
musica2.ExibirFichaTecnica();
Console.WriteLine("*******************");
albumDoVeigh.ExibirMusicasDoAlbum();
veigh.ExibirDiscografia();

