﻿using System;
using System.Linq;
namespace _08_MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = numbers.Length-1; k >i; k--)
                {
                    if (numbers[i] + numbers[k] == sum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[k]}");
                    }
                }


            }
            
        }
    }
}