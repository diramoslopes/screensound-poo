class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }
    // quando uma propriedade é somente leitura (get), temos uma outra maneira de escrever o codigo conhecido como lambda, abaixo o exemplo
    // public String DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
            Console.WriteLine(DescricaoResumida);
        }
        else
        {
            Console.WriteLine("Indisponivel. Adquira outro o plano Plus+");
        }

    }

}
