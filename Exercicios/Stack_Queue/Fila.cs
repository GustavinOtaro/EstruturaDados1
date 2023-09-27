using System;
using System.Security.Cryptography;

namespace StackClass
{
    public class Stack
    {
      static readonly int MAX = 1000;
      int first = -1;
      int[] stack = new int[MAX];

      public bool IsEmpty()
      {
        return (first < 0);
      }

      public bool Enqueue(int data)
      {
        if (first >= MAX)
        {
            Console.WriteLine("Stack Overflow");
            return false;
        }
        first += 1;
        stack[first] = data;
        return true;
      }

      public int Dequeue()
      {
        if(first < 0)
        {
            Console.WriteLine("Stack Overflow");
            return 0;
        }

        int valor = stack[first];
        first = first -1;
        return valor;
      }

      public void Peek()
      {
        if (first < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

        Console.WriteLine($"O topo da pilha é: {stack[first]}" );
      }

      public void PrintStack()
      {
        if(first < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }

        Console.WriteLine("Itens da Pilha:");
        for(int i = first; i >= 0; i--)
        {
            string texto = $"Stack[{ stack[i] }]";
            Console.WriteLine(texto);
        }
      }
    }
}