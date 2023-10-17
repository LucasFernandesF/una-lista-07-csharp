int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

ShellSort(vetor);

Console.WriteLine("Vetor ordenado:");
ImprimirVetor(vetor);

Console.ReadLine();

static void ShellSort(int[] arr)
{
    int tamanhoVetor = arr.Length;

    for (int gap = tamanhoVetor / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < tamanhoVetor; i++)
        {
            int temp = arr[i];

            int j;
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
            {
                arr[j] = arr[j - gap];
            }

            arr[j] = temp;
        }
    }
}

static void ImprimirVetor(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
