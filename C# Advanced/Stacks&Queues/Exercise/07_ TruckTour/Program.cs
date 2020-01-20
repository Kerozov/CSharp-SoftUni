using System;
using System.Collections.Generic;
using System.Linq;

namespace _07__TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pomps = new Queue<int[]>();
            bool isBreak = true;
            for (int i = 0; i < n; i++)
            {
                var pomp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pomps.Enqueue(pomp);
            }

            int counter = 0;
            while (true)
            {
                int fuelAmount = 0;
                for (int i = 0; i < n; i++)
                {
                    int[] currPomp = pomps.Dequeue();
                    fuelAmount += currPomp[0];
                    if (fuelAmount < currPomp[1])
                    {
                        isBreak = false;
                    }

                    fuelAmount -= currPomp[1];
                    pomps.Enqueue(currPomp);
                }

                if (isBreak)
                {
                   
                    break;
                }

                isBreak = true;
                counter++;
                pomps.Enqueue(pomps.Dequeue());
            }

            Console.WriteLine(counter);
        }
    }
}
