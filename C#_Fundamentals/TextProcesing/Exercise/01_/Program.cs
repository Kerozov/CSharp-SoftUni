using System;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ");
            foreach (var user in input)
            {
                bool isTrue = false;
                foreach (var item in user)
                {
                    if (((item > 64 && item < 91)
                                        || (item > 96 && item < 123)
                                        || (item > 47 && item < 58)
                                        || (item == 95)
                                        || (item == 45))
                                        && (user.Length > 2 && user.Length < 17))
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}