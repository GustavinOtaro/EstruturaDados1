using System;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> tabela = new Dictionary<string, string>(100);

        while (true)
        {
            Console.WriteLine("Insira o CPF:");
            string cpf = Console.ReadLine();

            if (tabela.ContainsKey(cpf))
            {
                Console.WriteLine("Chave já inserida.");
                continue;
            }

            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();

            tabela.Add(cpf, nome);

            Console.WriteLine("Deseja inserir mais um par de chave/valor? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() != "S")
            {
                break;
            }
        }

        foreach (var item in tabela)
        {
            Console.WriteLine("CPF: {0}, Nome: {1}", item.Key, item.Value);
        }
    }
}