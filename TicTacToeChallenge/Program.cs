using System.Security.Principal;

namespace TicTacToeChallenge
{
    internal class Program
    {
        static void Board(string[,] board)
        {
            Console.WriteLine("           |           |           ");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((i != 0 && j != 2) || (i != 1 && j != 2) || (i != 2 && j != 2))
                    {
                        Console.Write("     " + board[i, j] + "     |");
                    }
                    else
                    {
                        Console.Write("     " + board[i, j]);
                    }
                }
                Console.WriteLine("       ");
                if (i != 2)
                {
                    Console.Write(" __________|___________|___________");
                }
                if (i != 2)
                {
                    Console.Write("\n           |           |\n");
                }
                else
                {
                    Console.WriteLine("           |           |");
                }
            }
        }

        static bool isGame(string[,] board)
        {
            bool result = (board[0, 0] != board[1, 1] || board[1, 1] != board[2, 2])
                || (board[0, 2] != board[1, 1] || board[1, 1] != board[2, 0])
                || (board[0, 0] != board[1, 0] || board[1, 0] != board[2, 0])
                || (board[0, 1] != board[1, 1] || board[1, 1] != board[2, 1])
                || (board[0, 2] != board[1, 2] || board[1, 2] != board[2, 2])
                || (board[0, 0] != board[0, 1] || board[0, 1] != board[0, 2])
                || (board[1, 0] != board[1, 1] || board[1, 1] != board[1, 2])
                || (board[2, 0] != board[2, 1] || board[2, 1] != board[2, 2]);
            return result;
        }
        static void Main(string[] args)
        {
            string[,] board = {
                {"1", "2" ,"3"},
                {"4", "5" ,"6"},
                {"7", "8" ,"9"}
            };
            do
            {

                Board(board);

                string playerOInput;
                int playerOInt;

                Console.WriteLine("\nPlayer \"O\" choose your field: ");
                playerOInput = Console.ReadLine();
                bool isPlayerOInt = int.TryParse(playerOInput, out playerOInt);

                if (isPlayerOInt)
                {
                    string playerXInput;
                    int playerXInt;

                    Console.WriteLine("\nPlayer \"X\" choose your field: ");
                    playerXInput = Console.ReadLine();
                    bool isPlayerXInt = int.TryParse(playerXInput, out playerXInt);
                    if (isPlayerXInt)
                    {
                        switch (playerOInt)
                        {
                            case 1:
                                board[0, 0] = "O";
                                break;
                            case 2:
                                board[0, 1] = "O";
                                break;
                            case 3:
                                board[0, 2] = "O";
                                break;
                            case 4:
                                board[1, 0] = "O";
                                break;
                            case 5:
                                board[1, 1] = "O";
                                break;
                            case 6:
                                board[1, 2] = "O";
                                break;
                            case 7:
                                board[2, 0] = "O";
                                break;
                            case 8:
                                board[2, 1] = "O";
                                break;
                            case 9:
                                board[2, 2] = "O";
                                break;
                        }
                        switch (playerXInt)
                        {
                            case 1:
                                board[0, 0] = "X";
                                break;
                            case 2:
                                board[0, 1] = "X";
                                break;
                            case 3:
                                board[0, 2] = "X";
                                break;
                            case 4:
                                board[1, 0] = "X";
                                break;
                            case 5:
                                board[1, 1] = "X";
                                break;
                            case 6:
                                board[1, 2] = "X";
                                break;
                            case 7:
                                board[2, 0] = "X";
                                break;
                            case 8:
                                board[2, 1] = "X";
                                break;
                            case 9:
                                board[2, 2] = "X";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, try again");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (isGame(board));

            Board(board);

        }
    }
}