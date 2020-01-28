using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[row] = line;
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Count() == matrix[row + 1].Count())
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }

            while (true)
            {
                var command = Spliter();
                if (command[0] == "End")
                {
                    break;
                }

                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);
                if (!isValidCoordinates(matrix, row, col))
                {
                    continue;
                }
                else if (command[0] == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

        }

        static bool isValidCoordinates(double[][] matrix, int rows, int cols)
        {

            if (rows >= 0 && rows < matrix.Length)
            {
                if (cols >= 0 && cols < matrix[rows].Length)
                {
                    return true;
                }
            }
            return false;
        }

        static string[] Spliter() => Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    }

}

