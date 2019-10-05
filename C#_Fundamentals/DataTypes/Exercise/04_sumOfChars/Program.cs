using System;

namespace _04_sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < number; i++)
            {
                char name = char.Parse(Console.ReadLine());
                sum += (int)name;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
