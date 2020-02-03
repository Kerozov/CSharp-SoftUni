using System;
using System.Linq;

namespace _03_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
        .ToList();
            input = input.Where(x => (char.IsUpper(x[0]))).ToList();
            input.ForEach(Console.WriteLine);

        }
    }
}
