using System;
using System.Collections.Generic;
using System.Linq;
namespace _01_Train
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            
            while (line!="end")
            {
                string[] passenger =line.Split(' ');
                if (passenger.Length==2)
                {
                    train.Add(int.Parse(passenger[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        
                        if (int.Parse(passenger[0]) + train[i] <= maxCapacity)
                        {
                            train[i] = int.Parse(passenger[0]) + train[i];
                            break;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",train));
            
        }
    }
}
