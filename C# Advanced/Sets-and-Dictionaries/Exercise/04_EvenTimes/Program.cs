using System;
using System.Collections.Generic;

namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(num))
                {
                    numbers[num] = 0;   
                }

                numbers[num]++;
            }

            foreach (var (key,value) in numbers)
            {
                if (value%2==0)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}
