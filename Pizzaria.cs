
// Pizzaria
// Pedir pizza

var sabores = new List<Sabor>
{
    new Sabor
    {
        Numero = 1,
        Nome = "Quatro queijos"
    },
    new Sabor
    {
        Numero = 2,
        Nome = "Veg"
    },
    new Sabor
    {
        Numero = 3,
        Nome = "Milho"
    },
    new Sabor
    {
        Numero = 4,
        Nome = "Palmito"
    },
    new Sabor
    {
        Numero = 5,
        Nome = "Abobrinha"
    }
};

var tamanhos = new List<Tamanho>
{
    new Tamanho
    {
        Numero = 1,
        Nome = "Pequena",
        NomeQuantidadeSabores = "Um Sabor"
    },
    new Tamanho
    {
        Numero = 2,
        Nome = "Media",
        NomeQuantidadeSabores = "Dois Sabores"
    },
    new Tamanho
    {
        Numero = 3,
        Nome = "Grande",
        NomeQuantidadeSabores = "Tres Sabores"
    }
};

Console.WriteLine("Bem vindo a pizzaria Vintage Culture");
Console.WriteLine();
Console.WriteLine("Qual é o seu nome?");
string nomeUsuario = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Boa noite {nomeUsuario}!");
Console.WriteLine();
Console.WriteLine("Por favor, escolha o tamanho da sua pizza:");
Console.WriteLine();

foreach (var Tamanho in tamanhos)
{
    Console.WriteLine($"{Tamanho.Numero} - {Tamanho.Nome} ({Tamanho.NomeQuantidadeSabores})");
}
Console.WriteLine();

int numeroTamanho = 0;
int quantidadeDeSabores = 0;

while(numeroTamanho <= 0 || numeroTamanho > tamanhos.Count)
{
    int.TryParse(Console.ReadLine(), out numeroTamanho);

    switch (numeroTamanho)
    {
        case 1:
            quantidadeDeSabores = 1;
            break;
        case 2:
            quantidadeDeSabores = 2;
            break;
        case 3:
            quantidadeDeSabores = 3;
            break;
        default:
            Console.WriteLine("Por favor, digite um tamanho de pizza válido, '1', '2' ou '3'.");
            break;

    }

}

Console.WriteLine();
Console.WriteLine($"Ótimo! Agora por favor escolha {numeroTamanho} sabores (Digite o código):");
Console.WriteLine();

foreach (var sabor in sabores)
{
    Console.WriteLine($"{sabor.Numero}: {sabor.Nome}");
}

Console.WriteLine();
// Estou dizendo explícitamente quantos sabores de pizza poderá ser escolhido conforme o numero que o usuario digite, tentar automatizar isso.

var saboresInformados = new List<Sabor>();

while(saboresInformados.Count < quantidadeDeSabores)
{
    Console.Write("Informe o número de um sabor: ");
    
    int numeroSaborInt = 0;
    int.TryParse(Console.ReadLine(), out numeroSaborInt);

    if (numeroSaborInt <= 0 || numeroSaborInt > sabores.Count)
    {
        Console.WriteLine();
        Console.WriteLine($"Por favor insira o código de um sabor válido, de 1 a {sabores.Count}");
        continue;
    }


    Sabor saborEscolhido = sabores.FirstOrDefault(x => x.Numero == numeroSaborInt);
    saboresInformados.Add(saborEscolhido);
    Console.WriteLine($"Sabor escolhido -> {saborEscolhido.Nome}");
    Console.WriteLine();
    // saboresInformados.Sort(()) => string.Compare(x.Numero, y.Numero);
    // Organizar a lista de saboresInformados em ordem, pois o usuário pode escolher em diferente ordem, para
    // então após ser mostrado o pedido finalizado em ordem crescente.
}

Console.WriteLine($"{nomeUsuario}! Seu pedido foi recebido. Aqui está.");

Console.WriteLine();
Console.WriteLine($"Sabores escolhidos:");
foreach(var pedidoFinalizado in saboresInformados)
{
    Console.WriteLine(pedidoFinalizado);
}

Console.WriteLine();

Console.WriteLine("O tempo de entrega é de 50-60min");
