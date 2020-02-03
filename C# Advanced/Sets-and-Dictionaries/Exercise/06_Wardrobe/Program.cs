using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrope = new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var color = line[0];
                var clotches = line[1].Split(',').ToArray();
                if (!wardrope.ContainsKey(color))
                {
                    wardrope[color] = new Dictionary<string, int>();
                }

                foreach (var clotch in clotches)
                {
                    if (!wardrope[color].ContainsKey(clotch))
                    {
                        wardrope[color].Add(clotch,0);
                    }

                    wardrope[color][clotch]++;
                }
            }

            var itemToFound = Console.ReadLine().Split();
            var colorFound = itemToFound[0];
            var itemFound = itemToFound[1];
            foreach (var (color,items) in wardrope)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var item in items)
                {
                    if (colorFound==color&&itemFound==item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
