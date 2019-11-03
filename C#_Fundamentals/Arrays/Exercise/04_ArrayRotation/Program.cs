using System;
using System.Linq;
namespace _04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {

                int num = numbers[numbers.Length - 1];
                numbers[numbers.Length - 1] = numbers[0];
                for (int k = 1; k < numbers.Length; k++)
                {
                    numbers[k-1 ] = numbers[k];
                    
                }
                        numbers[numbers.Length - 2] = num;

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
