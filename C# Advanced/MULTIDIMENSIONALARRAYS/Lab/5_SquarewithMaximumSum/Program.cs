
namespace _5_SquarewithMaximumSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = GetInput(',',' ');
            int rows = input[0];
            int cols = input[1];
            var matrix = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                var currentLine = GetInput(',', ' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            var maxValue = int.MinValue;
            var currentCol = 0;
            var currentRow = 0;
            for (int row = 0; row < rows-1; row++)
            {
                var currentSum = 0;
                for (int col = 0; col < cols-1; col++)
                {
                    currentSum = matrix[row, col]
                                  + matrix[row, col + 1]
                                  + matrix[row + 1, col]
                                  + matrix[row + 1, col + 1];
                    if (currentSum > maxValue)
                    {
                        maxValue = currentSum;
                        currentRow = row;
                        currentCol = col;
                    }
                }

                
            }

            Console.WriteLine(matrix[currentRow,currentCol] +" "+ matrix[currentRow, currentCol+1]);
            Console.WriteLine(matrix[currentRow+1, currentCol] + " "+ matrix[currentRow+1, currentCol+1]);
            Console.WriteLine(maxValue);
           
        }

        private static int[] GetInput(params char[]symbolSplit) => Console.ReadLine().Split(symbolSplit,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    }
}
