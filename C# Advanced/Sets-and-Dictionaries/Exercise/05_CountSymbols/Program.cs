using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var chars = new Dictionary<char,int>();
            foreach (var curr in input)
            {
                if (!chars.ContainsKey(curr))
                {
                    chars[curr] = 0;
                }

                chars[curr]++;
            }

            chars = chars.OrderBy(x => x.Key).ToDictionary(x=>x.Key,z=>z.Value);
            foreach (var (key,value) in chars)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
