using System;

namespace _08_MathPower
{
    class Program
    {
        static int NumberPower(int number,int power)
        {
            int result = 1;
                 for (int i = 1; i <power/2; i++)
            {
                result = number*number;
            }
            return number;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberPower(number,power));
        }
    }
}
