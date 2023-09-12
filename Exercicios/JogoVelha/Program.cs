using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; 
    static int choice; 

    static int flag = 0; 

    static void Main()
    {
        do
        {
            Console.Clear(); 
            Console.WriteLine("Jogador 1: X e Jogador 2: O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("Turno do Jogador 2");
            }
            else
            {
                Console.WriteLine("Turno do Jogador 1");
            }
            Console.WriteLine("\n");
            Board();

            bool validChoice = false;
            while (!validChoice)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            }

            if (player % 2 == 0)
            {
                board[choice - 1] = 'O';
                player++;
            }
            else
            {
                board[choice - 1] = 'X';
                player++;
            }
            flag = CheckWin();
        }
        while (flag != 1 && flag != -1);

        Console.Clear();
        Board();
        if (flag == 1)
        {
            Console.WriteLine("Jogador {0} ganhou!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Empate!");
        }
        Console.ReadLine();
    }

    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condition
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Checking For Draw
        else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' &&
            board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }

    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }
}