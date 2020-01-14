using System;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double stepLong = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            double allSteps = 0;
            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    allSteps+= stepLong * 0.70;
                }
                else
                {

                allSteps += stepLong;
                }
            }
                allSteps = allSteps / 100;
            double percentage = allSteps / distance * 100;
            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
