using System;
using System.Data;
using System.Linq;

namespace _04_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Spliter();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);
            var matrix = GetInputMatrix(rows, cols);
            while (true)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] != "swap" || command.Length !=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                var curRow = int.Parse(command[1]);
                var curCol = int.Parse(command[2]);
                var newRow = int.Parse(command[3]);
                var newCol = int.Parse(command[4]);

                if (curRow < 0 || curRow > matrix.GetLength(0) - 1
                 || curCol < 0 || curCol > matrix.GetLength(1) - 1
                 || newRow < 0 || newRow > matrix.GetLength(0) - 1
                 || newCol < 0 || newCol > matrix.GetLength(1) - 1
                   )
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }



                var currentValue = matrix[curRow, curCol];
                var newValue = matrix[newRow, newCol];
                matrix[curRow, curCol] = newValue;
                matrix[newRow, newCol] = currentValue;
                PrintMatrix((matrix));
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
        static string[,] GetInputMatrix(int rows, int cols)
        {
            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Spliter();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            return matrix;
        }
        static string[] Spliter() => Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    }
}
