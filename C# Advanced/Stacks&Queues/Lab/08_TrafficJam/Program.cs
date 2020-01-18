using System;
using System.Collections;
using System.Collections.Generic;

namespace _08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPassCars = int.Parse(Console.ReadLine());
            var passed = new Queue<string>();
            int passedCars = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
               else if (command=="green")
                {
                    if (passed.Count==0)
                    {
                        continue;
                    }
                    if (countPassCars>passed.Count)
                    {
                        for (int i = 0; i <= passed.Count; i++)
                        {
                            Console.WriteLine($"{passed.Dequeue()} passed!");
                            passedCars++;
                        }
                        continue;
                    }
                    for (int i = 0; i < countPassCars; i++)
                    {
                        Console.WriteLine($"{passed.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    passed.Enqueue(command);
                }

            }
           Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }

       
    }
}
