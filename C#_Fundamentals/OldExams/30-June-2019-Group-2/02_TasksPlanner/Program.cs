using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();



            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] command = line.Split();
                if (command[0] == "Complete")
                {
                    int index = int.Parse(command[1]);
                    if (index < times.Count && index >= 0)
                    {
                        times[index] = 0;
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    int number = int.Parse(command[2]);
                    if (index < times.Count && index >= 0)
                    {
                        times[index] = number;
                    }

                }
                else if (command[0] == "Drop")
                {

                    int index = int.Parse(command[1]);
                    if (index < times.Count && index >= 0)
                    {
                        times[index] = -1;
                    }
                }
                else if (command[0] == "Count")
                {

                    if (command[1] == "Completed")
                    {
                        int complete = 0;

                        for (int i = 0; i < times.Count; i++)
                        {
                            if (times[i] == 0)
                            {
                                complete++;

                            }
                        }

                        Console.WriteLine(complete);
                    }
                    else if (command[1] == "Incomplete")
                    {
                        int uncopmplited = 0;
                        for (int i = 0; i < times.Count; i++)
                        {
                            if (times[i] > 0)
                            {
                                uncopmplited++;

                            }
                        }
                        Console.WriteLine(uncopmplited);
                    }
                    else if (command[1] == "Dropped")
                    {
                        int drop = 0;
                        for (int i = 0; i < times.Count; i++)
                        {
                            if (times[i] == -1)
                            {
                                drop++;

                            }
                        }
                        Console.WriteLine(drop);
                    }

                }

                line = Console.ReadLine();

            }
            for (int i = 0; i < times.Count; i++)
            {
                if (times[i] == 0 || times[i] == -1)
                {
                    times.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", times));
        }
    }
}
