using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}