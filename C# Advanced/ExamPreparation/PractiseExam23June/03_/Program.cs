using System;
using System.Linq;
namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] field = new char[n][];
            int playerRow = -1;
            int playerCol = -1;
            int starPower = 0;
            GetMatrix(n, field, ref playerRow, ref playerCol);
            while (starPower < 50)
            {
                var command = Console.ReadLine();
                if (command == "up")
                {
                    var nextRow = playerRow - 1;
                    var nextCol = playerCol;
                    if (nextRow < 0)
                    {
                        field[playerRow][playerCol] = '-';
                        break;
                    }
                    Movement(n, field, ref playerRow, ref playerCol, ref starPower, nextRow, nextCol);

                }
                else if (command == "down")
                {
                    var nextRow = playerRow + 1;
                    var nextCol = playerCol;
                    if (nextRow >= n)
                    {
                        field[playerRow][playerCol] = '-';
                        break;
                    }
                    Movement(n, field, ref playerRow, ref playerCol, ref starPower, nextRow, nextCol);

                }
                else if (command == "left")
                {
                    var nextRow = playerRow;
                    var nextCol = playerCol - 1;
                    if (nextCol < 0)
                    {
                        field[playerRow][playerCol] = '-';
                        break;
                    }
                    Movement(n, field, ref playerRow, ref playerCol, ref starPower, nextRow, nextCol);

                }
                else if (command == "right")
                {

                    var nextRow = playerRow;
                    var nextCol = playerCol + 1;
                    if (nextCol >= n)
                    {
                        field[playerRow][playerCol] = '-';
                        break;
                    }
                    Movement(n, field, ref playerRow, ref playerCol, ref starPower, nextRow, nextCol);

                }
            }
            PrintOutput(n, field, starPower);
        }

        private static void PrintOutput(int n, char[][] field, int starPower)
        {
            if (starPower < 50)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            Console.WriteLine($"Star power collected: {starPower}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void Movement(int n, char[][] field, ref int playerRow, ref int playerCol, ref int starPower, int nextRow, int nextCol)
        {
            if (char.IsDigit(field[nextRow][nextCol]))
            {
                starPower += (int)field[nextRow][nextCol] - 48;
                field[playerRow][playerCol] = '-';
                field[nextRow][nextCol] = 'S';
                playerCol = nextCol;
                playerRow = nextRow;
            }
            else if (field[nextRow][nextCol] == 'O')
            {
                initialHold(n, field, ref playerRow, ref playerCol, nextRow, nextCol);
            }
            else
            {
                field[playerRow][playerCol] = '-';
                field[nextRow][nextCol] = 'S';
                playerCol = nextCol;
                playerRow = nextRow;
            }
            
        }

        private static void GetMatrix(int n, char[][] field, ref int playerRow, ref int playerCol)
        {
            for (int rows = 0; rows < n; rows++)
            {
                var row =
                    Console.ReadLine().ToCharArray();
                field[rows] = row;
                for (int col = 0; col < n; col++)
                {
                    if (field[rows][col] == 'S')
                    {
                        playerRow = rows;
                        playerCol = col;
                    }
                }
            }
        }

        private static void initialHold(int n, char[][] field, ref int playerRow, ref int playerCol, int nextRow, int nextCol)
        {
            field[playerRow][playerCol] = '-';
            field[nextRow][nextCol] = '-';
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row][col] == 'O')
                    {
                        playerRow = row;
                        playerCol = col;
                        field[row][col] = 'S';
                    }
                }
            }
        }
    }
}
