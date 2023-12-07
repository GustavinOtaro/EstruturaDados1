using System;

class ExponentialSearch
{
    static int Search(int[] arr, int n, int x)
    {
        // Se o elemento estiver presente no índice 0, retorna 0
        if (arr[0] == x)
            return 0;

        // Encontra o intervalo para a busca binária
        int i = 1;
        while (i < n && arr[i] <= x)
            i = i * 2;

        // Aplica a busca binária no intervalo encontrado
        return BinarySearch(arr, i / 2, Math.Min(i, n - 1), x);
    }

    static int BinarySearch(int[] arr, int start, int end, int x)
    {
        if (end >= start)
        {
            int mid = start + (end - start) / 2;

            // Verifica se o elemento está presente no meio
            if (arr[mid] == x)
                return mid;

            // Se o elemento for menor que o meio, busca na metade esquerda
            if (arr[mid] > x)
                return BinarySearch(arr, start, mid - 1, x);

            // Caso contrário, busca na metade direita
            return BinarySearch(arr, mid + 1, end, x);
        }

        // Retorna -1 se o elemento não for encontrado
        return -1;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;
        int x = 50;

        int result = Search(arr, n, x);

        if (result == -1)
            Console.WriteLine("Elemento não encontrado");
        else
            Console.WriteLine("Elemento encontrado no índice " + result);
    }
}
