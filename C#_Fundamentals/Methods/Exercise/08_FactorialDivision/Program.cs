using System;

namespace _08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = 0;
            long factorial1 = factorialOne(num1);
            long factorial2 = factorialTwo(num2);
            result = (factorialOne(num1)*1.0 / factorialTwo(num2));

            Console.WriteLine($"{result:f2}");
        }
        static long factorialOne(int num1)
        {
            long result = 1;
            if (num1 == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= num1; i++)
                {
                    result *= i;
                }

            }
            return result;
        }
        static long factorialTwo(int num2)
        {
            if (num2 == 0)
            {
                return 1;
            }
            else
            {
                long result = 1;
                for (int i = 1; i <= num2; i++)
                {
                    result *= i;
                }
                return result;

            }
        }

    }
}
