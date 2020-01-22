using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetInput(',');
            int cols = input[1];
            int rows = input[0];
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var currntLine = GetInput(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currntLine[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }

        private static int[] GetInput(params char[]symbolSplit) => Console.ReadLine().Split(symbolSplit).Select(int.Parse).ToArray();
       
    }
}
