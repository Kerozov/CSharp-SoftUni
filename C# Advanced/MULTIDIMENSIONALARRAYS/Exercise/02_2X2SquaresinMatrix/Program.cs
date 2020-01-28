using System;
using System.Linq;

namespace _02_2X2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new char[coordinates[0], coordinates[1]];
            for (int row = 0; row < coordinates[0]; row++)
            {
                var value = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < coordinates[1]; col++)
                {
                    matrix[row, col] = char.Parse(value[col]);
                }
            }

            int count = 0;
            for (int row = 0; row < coordinates[0]; row++)
            {
                for (int col = 0; col < coordinates[1]; col++)
                {
                    if ((row + 1 < matrix.GetLength(0)) && (col + 1 < matrix.GetLength(1)))
                    {
                        char current = matrix[row, col];
                        if (current == matrix[row, col + 1] && matrix[row + 1, col] == current && matrix[row + 1, col + 1] == current)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
