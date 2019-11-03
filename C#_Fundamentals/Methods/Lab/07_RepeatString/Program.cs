using System;

namespace _07_RepeatString
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double input =double.Parse(Console.ReadLine());
            double repeat = double.Parse(Console.ReadLine());
            double result = 1;
            for (int i = 0; i < repeat; i++)
            {
               result *= input;
            }
            Console.Write(result);
        }
    }
}
