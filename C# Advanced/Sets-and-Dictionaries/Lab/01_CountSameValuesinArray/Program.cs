using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var dict = new Dictionary<double, double>();
            foreach (var num in input)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }

                dict[num]++;
            }

            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}