using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names =new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
                if (command=="Paid")
                {
                    int count = names.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (names.Any())
                        {
                            Console.WriteLine(names.Dequeue());
                        }
                    }
                    continue;
                }
                names.Enqueue(command);
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
