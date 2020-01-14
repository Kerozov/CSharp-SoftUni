using System;
using System.Collections.Generic;
using System.Linq;

namespace _01__CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dict = new SortedDictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (!dict.ContainsKey(currentNumber))
                {
                    dict[currentNumber] = 0;
                }
                dict[currentNumber]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
