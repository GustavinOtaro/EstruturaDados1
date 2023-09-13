using System;

public class StackOfString
{
    private string[] stackArray;
    private int top;

    public StackOfString(int capacity)
    {
        stackArray = new string[capacity];
        top = -1;
    }

    public void Push(string item)
    {
        if (top < stackArray.Length - 1)
        {
            top++;
            stackArray[top] = item;
        }
        else
        {
            Console.WriteLine("A pilha está cheia. Não é possível empilhar mais elementos.");
        }
    }

    public string? Pop()
    {
        if (top >= 0)
        {
            string item = stackArray[top];
            top--;
            return item;
        }
        else
        {
            Console.WriteLine("A pilha está vazia. Não é possível desempilhar elementos.");
            return null;
        }
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public string? Peek()
    {
        if (top >= 0)
        {
            return stackArray[top];
        }
        else
        {
            Console.WriteLine("A pilha está vazia. Não há elementos para espiar.");
            return null;
        }
    }

    public int Count()
    {
        return top + 1;
    }
}