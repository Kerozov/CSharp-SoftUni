using System;
using System.Linq;

namespace _05_TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                   
                for (int k = i+1; k < numbers.Length; k++)
                {
                    if (numbers[i] <=numbers[k])
                    {
                        break;

                    }
                    if (numbers[i]>numbers[k]&&k==numbers.Length-1)
                    {
                        Console.Write(numbers[i]+" ");
                    }
                }
            }
            Console.WriteLine($"{numbers[numbers.Length-1]}");
        }
    }
}
