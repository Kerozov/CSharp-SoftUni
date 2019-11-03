using System;
using System.Linq; 
namespace _03_zigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number1 = new int[n];
            int[] number2 = new int[n];
            
            for (int i = 1; i <= n; i++)
            {
               int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
               
                if (i%2==1)
                {
                    number1[i-1] = nums[0];
                    number2[i-1] = nums[1];
                }
                else
                {
                    number2[i-1] = nums[0];
                    number1[i-1] = nums[1];
                }

            }
            Console.Write(string.Join(" ",number1));
            Console.WriteLine();
            Console.Write(string.Join(" ",number2));
        }
    }
}
