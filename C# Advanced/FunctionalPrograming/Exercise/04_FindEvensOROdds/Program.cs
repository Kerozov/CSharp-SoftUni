using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _04_FindEvensOROdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();
            string command = Console.ReadLine();
            Predicate<int> even = new Predicate<int>(n=>n % 2 == 0);
            Predicate<int> odd = new Predicate<int>(n=>n % 2 != 0);
            var evenorOdd = command == "even" ? even : odd;
           
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (evenorOdd(i))
                {
                    result.Add(i);
                }
            }
            result.ForEach(x=>Console.Write(x+" "));
    }
}
}
