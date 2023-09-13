class Program
{
    static void Main(string[] args)
    {
        StackOfString stack = new StackOfString(5);

        stack.Push("Carne");
        stack.Push("Arroz");
        stack.Push("Salada");

        Console.WriteLine("Elemento no topo da pilha: " + stack.Peek());

        Console.WriteLine("Desempilhando elementos:");
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }

        Console.WriteLine("Número de elementos na pilha: " + stack.Count());
    }
}