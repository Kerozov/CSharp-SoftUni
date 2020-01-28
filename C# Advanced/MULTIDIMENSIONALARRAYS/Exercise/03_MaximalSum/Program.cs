using System;
using System.Linq;

namespace _03_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Spliter();
            var matrix = GetInputMatrix(input[0], input[1]);
            var maxMatrix = new int[3, 3];
            int maxSum = int.MinValue;
            int index = 0;
            for (int row = 0; row < input[0] - 2; row++)
            {
                for (int col = 0; col < input[1] - 2; col++)
                {
                    int currentValue = 0;
                    currentValue = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                   matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                  + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentValue > maxSum)
                    {
                        maxSum = currentValue;
                        for (int r = 0; r < 3; r++)
                        {
                            for (int c = 0; c < 3; c++)
                            {
                                maxMatrix[r, c] = matrix[row + r, c + col];
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(maxMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static int[,] GetInputMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];
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
        static int[] Spliter() => Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    }
}
