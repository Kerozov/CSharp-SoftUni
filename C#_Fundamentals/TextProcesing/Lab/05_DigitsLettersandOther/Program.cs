using System;

namespace _05_DigitsLettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = "";
            string symbol = "";
            string num = "";

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] > 96 && input[i] < 123)
                    || (input[i] > 64 && input[i] < 91))
                {
                    text += input[i];
                }
                else if (input[i] >= 48&& input[i] <= 57)
                {
                    num += input[i];
                }
                else
                {
                    symbol += input[i];
                }
            }
            Console.WriteLine(num);
            Console.WriteLine(text);
            Console.WriteLine(symbol);
        }
    }
}
