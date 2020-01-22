using System;
using System.Linq;

namespace _04_SymbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new char[rows][];
            bool isContain = false;
            for (int  row= 0; row < rows;row ++)
            {
                var currentLine = Console.ReadLine().ToCharArray();
                matrix[row] = currentLine;
            }

            var symbol = Console.ReadLine().Split().Select(char.Parse).ToArray();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (symbol[0]==matrix[row][col])
                    {
                        isContain = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }

                if (isContain)
                {
                    break;

                }
            }

            if (!isContain)
            {
                Console.WriteLine($"{symbol[0]} does not occur in the matrix");
            }
        }
    }
}
