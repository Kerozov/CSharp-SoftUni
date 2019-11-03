using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> field = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNumber = tokens[0];
            int power = tokens[1];
            for (int i = 0; i < field.Count; i++)
            {
                int target = field[i];
                if (bombNumber==target)
                {
                    BombNumbers(field,power,i);
                }
            }
            Console.WriteLine(field.Sum());
        }
        static void BombNumbers(List<int> field, int power ,int i)
        {
            int start = Math.Max(0, i - power);
            int end = Math.Min(field.Count, i + power);
            for (int k = start; k <= end; k++)
            {
                field[k] = 0;
            }
        }
    }
}
  