using System;
using System.Linq;

namespace _03_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .Min();
            Console.WriteLine(number);
        }
    }
}
