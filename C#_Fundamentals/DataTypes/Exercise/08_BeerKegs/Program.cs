using System;

namespace _08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string bigestkegs = "";
            double volume = 0;
            double maxVolume = double.MinValue;
            string model = "";
            for (int i = 0; i < number; i++)
            {
                 model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius,2) * height;
                if (maxVolume< volume)
                {
                    bigestkegs = model;
                    maxVolume = volume;
                }

            }
            Console.WriteLine(bigestkegs);
        }
    }
}
