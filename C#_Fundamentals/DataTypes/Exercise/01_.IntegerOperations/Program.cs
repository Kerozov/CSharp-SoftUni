using System;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());


            int sym = number2 + number1;
            int sym2 = sym / number3;
            int sum3 = sym2 * number4;
            Console.WriteLine(sum3);
        }
    }
}
