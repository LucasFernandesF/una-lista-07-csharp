int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

InsertionSort(vetor);

Console.WriteLine("Vetor ordenado:");
ImprimirVetor(vetor);

static void InsertionSort(int[] arr)
{
    int tamanhoVetor = arr.Length;

    for (int i = 1; i < tamanhoVetor; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;
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

Console.ReadLine();