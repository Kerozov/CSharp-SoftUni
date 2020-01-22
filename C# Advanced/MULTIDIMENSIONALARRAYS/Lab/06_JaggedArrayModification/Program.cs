using System;
using System.Linq;

namespace _06_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                var currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = currentLine;
            }

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                var curRow = int.Parse(command[1]);
                var curCol = int.Parse(command[2]);
                var value = int.Parse(command[3]);
                if (curCol<0||curRow<0||rows<=curRow||curCol>=jagged[curRow].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                  continue;
                }

                if (command[0]=="Add")
                {
                    jagged[curRow][curCol] = jagged[curRow][curCol]+value;
                }
                else if (command[0]=="Subtract")
                {
                    jagged[curRow][curCol] = jagged[curRow][curCol] - value;
                }
            }

            for (int row = 0; row <rows ; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
