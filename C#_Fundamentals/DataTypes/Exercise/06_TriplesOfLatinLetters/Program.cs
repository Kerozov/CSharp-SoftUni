using System;

namespace _06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <number ; j++)
                {
                    for (int k = 0; k <number ; k++)
                    {
                        char firstchar =(char) ('a' + i);
                        char second =(char) ('a' + j);
                        char thyrd =(char) ('a' + k);
                        Console.Write($"{firstchar}{second}{thyrd}");
                        Console.WriteLine();
                    }
                   
                }

            }
        }
    }
}
