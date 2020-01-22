using System;
using System.Linq;

namespace _03__PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                var currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = currentLine;
            }

            var sum = 0;
            for (int row = 0; row < rows; row++)
            {

                sum += matrix[row][row];
            }

            Console.WriteLine(sum);
        }
    }
}
