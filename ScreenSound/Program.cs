﻿//Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Zeca Pagodinho", new List<int>() {10, 10, 8, 7, 9 });
bandasRegistradas.Add("Bezerra da Silva", new List<int>());
bandasRegistradas.Add("Martinho da Vila", new List<int>() {10, 10, 6, 5, 4 });

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
        ");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine("A banda " + nomeDaBanda + " foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirListaBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
        ");
    Console.WriteLine("Exibindo todas as bandas registradas: ");
    //for(int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar pro menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ █▀▀   ▄▀█ █▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀█ ▀▄▀ █▀█ █▄▄ █ ██▄   █▀█ ▄█   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
        ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("\nPressione qualquer tecla para voltar pro menu principal..."); 
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }


}

void ExibirMediaBanda()
{
    Console.Clear();
    Console.WriteLine(@"
         ▀
█▀▄▀█ █▀▀ █▀▄ █ ▄▀█   █▀▄ ▄▀█ █▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█░▀░█ ██▄ █▄▀ █ █▀█   █▄▀ █▀█ ▄█   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
        ");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasBanda = bandasRegistradas[nomeBanda];
        
        Console.Write($"A média das notas da banda {nomeBanda} é: {notasBanda.Average()}");
        Console.WriteLine("\n\nPressione qualquer tecla para voltar pro menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("\nPressione qualquer tecla para voltar pro menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void ExibirOpcoesMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine(" ");
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibirListaBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: ExibirMediaBanda();
            break;
        case -1: Console.WriteLine("Até a proxima!  Tchau, tchau :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

//ExibirOpcoesMenu();

// Recriando a aplicação do ScreenSound
Episodio ep1 = new(45, 1, "Tecnicas de facilitação");
ep1.AdicionarConvidados("Messias");
ep1.AdicionarConvidados("Micael");
ep1.AdicionarConvidados("Maria Vanilda");
ep1.AdicionarConvidados("Manoel");

Episodio ep2 = new(77, 2, "Tecnicas de aprendizado");
ep2.AdicionarConvidados("Ivanete");
ep2.AdicionarConvidados("Renato");
ep2.AdicionarConvidados("Regina");
ep2.AdicionarConvidados("Vanildo");

Episodio ep3 = new(59, 3, "Tecnicas de compreender");
ep3.AdicionarConvidados("Lucas");
ep3.AdicionarConvidados("Joao");
ep3.AdicionarConvidados("Bruno");

Podcast podcast = new("Podcast Gemeos", "Ryan");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);

podcast.ExibirDetalhes();
