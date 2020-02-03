using System;
using System.Linq;

namespace _02_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myFunc = int.Parse;
            var numbers = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(myFunc).ToList();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
