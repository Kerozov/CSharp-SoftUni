using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            while (resource != "stop")
            {
                int count = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += count;
                resource = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
