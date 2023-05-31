Dictionary<string, List<int>> Animes = new Dictionary<string, List<int>>();
Animes.Add("Naruto", new List<int>() { 10, 9, 9, 10 });
Animes.Add("Jujutsu Kaisen", new List<int>());
Animes.Add("One Piece", new List<int>());

// Adicionar uma regra para quando salvar o nome do anime ele colocar ele em To Upper 

void Logo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   ▄▀█ █▄░█ █ █▀▄▀█ █▀▀
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   █▀█ █░▀█ █ █░▀░█ ██▄");
}

void Menu()
{
    Logo();
    Console.WriteLine("\n[1] - para registar um novo anime");
    Console.WriteLine("[2] - para ver a lista de animes");
    Console.WriteLine("[3] - para avaliar um anime");
    Console.WriteLine("[4] - para ver a média de notas de um anime");
    Console.WriteLine("[5] - para sair da aplicação");
    Console.WriteLine();
    Console.Write("Selecione uma opção: ");
    int escolha = int.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1:
            RegistarAnime();
            break;
        case 2:
            ListarAnimes();
            break;
        case 3:
            AvaliarAnime();
            break;
        case 4:
            ExibirMediaAnime();
            break;
        case 5:
            Console.WriteLine("Você saiu da aplicação!");
            break;
    }
}

void Cabecalho(string titulo)
{
    var quantidade = titulo.Length;
    var caractere = string.Empty.PadLeft(quantidade, '*');

    Console.WriteLine(caractere);
    Console.WriteLine(titulo);
    Console.WriteLine(caractere);
    Console.WriteLine();
}

void RegistarAnime()
{
    Console.Clear();
    Cabecalho("Registrar um anime");
    Console.Write("Digite o nome do anime: ");
    var anime = Console.ReadLine();
    Animes.Add(anime!, new List<int>());
    Console.WriteLine($"{anime} foi adicionado a sua lista com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}

void ListarAnimes()
{
    Console.Clear();
    Cabecalho("Lista de animes");
    foreach (var item in Animes.Keys)
    {
        Console.WriteLine(item);
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void AvaliarAnime()
{
    Console.Clear();
    Cabecalho("Avaliar um anime");
    Console.Write("Digite o nome do anime que deseja avaliar: ");
    string anime = Console.ReadLine()!;
    if (Animes.ContainsKey(anime))
    {
        Console.Write("Digite uma nota para o anime (1 - 10): ");
        int nota = int.Parse(Console.ReadLine()!);
        Animes[anime].Add(nota);
        Console.WriteLine($"\nA nota foi registrada com sucesso para o anime {anime}");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();

    }
    else
    {
        Console.WriteLine($"\nO anime: {anime} não foi localizado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

void ExibirMediaAnime()
{
    Console.Clear();
    Cabecalho("Média do anime");
    Console.Write("Digite o nome do anime que você quer ver a média: ");
    string anime = Console.ReadLine()!;
    if (Animes.ContainsKey(anime))
    {
        List<int> notas = Animes[anime];
        Console.WriteLine($"\nA média das notas para {anime} é: {notas.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"\nO anime: {anime} não foi localizado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

Menu();