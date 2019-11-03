using System;

namespace _06_MiddleCharacter
{
    class Program
    {


        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char symbol;



            if (text.Length % 2 == 0)
            {
                for (int i = 1; i < text.Length; i++)
                {

                    symbol = (char)(text[i - 1]);
                    if (i == text.Length / 2)
                    {
                        Console.Write(symbol);

                    }
                    if (text.Length % 2 == 0 && i == text.Length / 2)
                    {
                        Console.Write((char)(text[i]));
                    }
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {

                    symbol = (char)(text[i]);
                    if (i == text.Length / 2)
                    {
                        Console.Write(symbol);

                    }
                }
            }
        }
    }
}
