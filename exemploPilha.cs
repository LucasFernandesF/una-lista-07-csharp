// criando um array de pilha com valores int
Stack<int> numeros = new Stack<int>();

// Adicionano valores int na pilha
numeros.Push(5);
numeros.Push(10);
numeros.Push(15);

// Percorrendo o vetor e imprimindo os valores
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

// Removendo ultimo valor impresso na pilha
numeros.Pop();

Console.WriteLine("Nova lista");

// Percorrendo o vetor e imprimindo os valores
foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

Console.ReadLine();