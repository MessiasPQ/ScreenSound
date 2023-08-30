using System.Runtime.Intrinsics.Arm;

class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach(Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possuí {TotalEpisodios} episódios.");
    }
}