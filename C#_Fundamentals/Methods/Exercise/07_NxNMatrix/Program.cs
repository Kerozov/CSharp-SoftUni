using System;

namespace _07_NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(number+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
