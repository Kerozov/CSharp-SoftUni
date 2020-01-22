using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixRowAndColFromConsole = GetMatrixRowFromConsole();
            int rows = matrixRowAndColFromConsole[0];
            int colums = matrixRowAndColFromConsole[1];
            var matrix = new int[rows, colums];
            for (int row = 0; row < rows; row++)
            {
                var element = GetMatrixRowFromConsole();
                for (int colum = 0; colum < colums; colum++)
                {
                    matrix[row, colum] = element[colum];
                }
            }

            int sum = 0;
            Console.WriteLine(rows);
            Console.WriteLine(colums);
            foreach (var number in matrix)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        private static int[] GetMatrixRowFromConsole()
        {
            return Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
