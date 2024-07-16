/* Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 9;
musica1.Disponivel = true;

musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 12;
musica2.Disponivel = false;

musica2.ExibirFichaTecnica(); */

/*Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();*/

Episodio ep1 = new(2, "Técnicas de facilitação", 45);

ep1.AdicionarConvidados("Ricardo");
ep1.AdicionarConvidados("Guilherme Silveira");
ep1.AdicionarConvidados("Carlos Silveira");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);

ep2.AdicionarConvidados("Fernanda");
ep2.AdicionarConvidados("Flavio");
ep2.AdicionarConvidados("Pedro");

Console.WriteLine(ep1.Resumo);

Podcast podcast = new Podcast("Hipster", "Paulo Silveira");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();