using System;

namespace _10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isTopNumber(int num)
        {
            int temp = num;
            int sum = 0;
            bool isodd = false;
            bool isTop = false;
            while (temp > 0)
            {
                int digits = temp % 10;
                sum += digits;
                temp /= 10;
                if (digits % 2 != 0)
                {
                    isodd = true;
                }
            }
            if (sum % 8 == 0)
            {
                isTop = true;
            }
            return isTop && isodd;

        }

    }
}
