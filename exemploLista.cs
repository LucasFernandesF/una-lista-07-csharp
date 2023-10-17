// Inicio da variavel nomes em um lista string
var nomes = new List<string> { "Luís", "Ana" };

// Percorre o array e imprime os valores
foreach (var nome in nomes)
{
    Console.WriteLine("Oi, " + nome);
}

// Adiciona outro valor string no array
nomes.Add("Pedro");
Console.WriteLine("Nova Lista");

// Percorre o array e imprime os novos valores
foreach (var nome in nomes)
{
    Console.WriteLine("Oi, " + nome);
}

Console.ReadLine();