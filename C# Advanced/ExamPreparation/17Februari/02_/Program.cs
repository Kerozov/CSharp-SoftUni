using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new string[n][];
            for (int row = 0; row < n; row++)
            {
                var currRow = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                matrix[row] = currRow;
            }

            string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string header = command[1];
            int headerIndex = Array.IndexOf(matrix[0], header);
            if (command[0] == "hide")
            {
                for (int row = 0; row < n; row++)
                {
                    var listToPrint = new List<string>(matrix[row]);
                    listToPrint.RemoveAt(headerIndex);
                    Console.WriteLine(string.Join(" | ", listToPrint));
                    matrix[row] = listToPrint.ToArray();
                }

            }
            else if (command[0] == "sort")
            {
                var headerRow = matrix[0];
                Console.WriteLine(string.Join(" | ", headerRow));
                matrix = matrix.OrderBy(x => x[headerIndex]).ToArray();
                foreach (var item in matrix)
                {
                    if (item != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", item));
                    }
                }
            }
            else if (command[0] == "filter")
            {
                string value = command[2];
                var headerRow = matrix[0];
                Console.WriteLine(string.Join(" | ", headerRow));
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][headerIndex] == value)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }
            }
        }
    }
}
