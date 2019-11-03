using System;

namespace _05_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            Sum(num1, num2);
            Console.WriteLine(Subtract(num3,Sum(num1, num2)));
        }
        static int Sum(int num1 ,int num2)
        {
            
            return num1 + num2;

        }
        static int Subtract(int num3 , int sum)
        {
            return sum- num3 ;
        }
    }
}
