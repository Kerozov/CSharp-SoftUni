using System;
using System.Data;
using System.Linq;

namespace _01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];
            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = line;
            }

            int sum = 0;
            int secondSum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                secondSum += matrix[row][matrix[row].Length - row - 1];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row][col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sum-secondSum));
        }
    }
}
