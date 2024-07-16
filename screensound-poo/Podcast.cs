class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> episodios = new();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome}, Host do Podcast {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episodios: {episodio.Resumo}");
        }
        Console.WriteLine($"\n\nTotal de episodios: {TotalEpisodios}");

    }

}