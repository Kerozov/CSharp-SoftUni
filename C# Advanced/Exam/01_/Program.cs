using System;
using System.Linq;
namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var field = new char[n][];
            var coundCommand = int.Parse(Console.ReadLine());
            var oldRow = -1;
            var oldCol = -1;
            int playerRow = -1;
            int playerCol = -1;
            var playerWon = false;
            MatrixInput(n, field, ref playerRow, ref playerCol);
            oldRow = playerRow;
            oldCol = playerCol;
            for (int i = 0; i < coundCommand; i++)
            {
                var command = Console.ReadLine();
                var nextRow = playerRow;
                var nextCol = playerCol;
                oldCol = playerCol;
                oldRow = playerRow;
                InitialNextStep(command, ref nextRow, ref nextCol, ref oldRow, ref oldCol,ref playerRow,ref playerCol);
                ChekStep(n, ref nextRow, ref nextCol);
                if (field[nextRow][nextCol] == 'F')
                {
                    Movement(field, ref playerRow, ref playerCol, nextRow, nextCol);
                    playerWon = true;
                    if (i==coundCommand-1)
                    {
                        break;
                    }
                }
                else if (field[nextRow][nextCol] == 'B')
                {
                    field[playerRow][playerCol] = '-';
                    InitialNextStep(command, ref nextRow, ref nextCol,ref oldRow,ref oldCol, ref playerRow, ref playerCol);
                    ChekStep(n, ref nextRow, ref nextCol);
                    if (field[nextRow][nextCol] == 'F')
                    {
                        Movement(field, ref playerRow, ref playerCol, nextRow, nextCol);
                        playerWon = true;
                       
                            break;
                        
                    }
                    field[nextRow][nextCol] = 'f';
                    playerRow = nextRow;
                    playerCol = nextCol;
                }
                else if (field[nextRow][nextCol] == 'T')
                {
                    playerRow = oldRow;
                    playerCol = oldCol;
                }
                else if(field[nextRow][nextCol] == '-')
                {

                    Movement(field, ref playerRow,ref playerCol, nextRow, nextCol);
                }
            }
            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void ChekStep(int n, ref int nextRow, ref int nextCol)
        {
            if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n)
            {
                if (nextRow < 0)
                {
                    nextRow = n - 1;
                }
                else if (nextRow >= n)
                {
                    nextRow = 0;
                }
                else if (nextCol < 0)
                {
                    nextCol = n - 1;
                }
                else if (nextCol >= n)
                {
                    nextCol = 0;
                }
            }
        }

        private static void MatrixInput(int n, char[][] field, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < n; row++)
            {
                var curRow = Console.ReadLine().ToCharArray();
                field[row] = curRow;
                for (int col = 0; col < curRow.Length; col++)
                {
                    if (curRow[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }

        private static void Movement(char[][] field,ref int playerRow,ref int playerCol, int nextRow, int nextCol)
        {
            field[playerRow][playerCol] = '-';
            field[nextRow][nextCol] = 'f';
            playerRow = nextRow;
            playerCol = nextCol;
        }

        private static void InitialNextStep(string command, ref int nextRow, ref int nextCol,ref int oldRow, ref int oldCol,ref int playerRol,ref int playerCol)
        {
            if (command == "up")
            {
                nextRow--;
            }
            else if (command == "down")
            {
                nextRow++;
            }
            else if (command == "right")
            {
                nextCol++;
            }
            else if (command == "left")
            {
                nextCol--;
            }
        }
    }
}
