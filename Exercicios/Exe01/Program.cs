int[] vetor= {0,1,2,3,4,5,6,7,8,9}
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"vetor[{i}] = {vetor[i]}");
}

Console.WriteLine("Ordenado");

for(int i = 0; i < vetor.Length - 1; i++)
{
    for(int j = i + 1; j < vetor.Length; j++)
    {
        int aux = vetor[j];
        if(vetor[j]< vetor[i])
        {
            vetor[j] = vetor[i];
            vetor[i] = aux;
        }
    }
}







