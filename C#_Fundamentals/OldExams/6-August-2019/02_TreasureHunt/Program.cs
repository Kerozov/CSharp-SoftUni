using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> lootChest = Console.ReadLine()
                .Split('|')
                .ToList();
            string line = Console.ReadLine();
            while (line!="Yohoho!")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command== "Loot")
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (!lootChest.Contains(lines[i]))
                        {
                            lootChest.Insert(0,lines[i]);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(lines[1]);
                    if (index>=0&&index<lootChest.Count)
                    {
                        lootChest.Add(lootChest[index]);
                        lootChest.RemoveAt(index);
                    }
                }
                else if (command == "Steal")
                {
                  int  count = int.Parse(lines[1]);
                    List<string> steal = new List<string>();
                    for (int i = 0; i < lootChest.Count; i++)
                    {
                        if (lootChest.Count-count<=i&&count>=0)
                        {
                            steal.Add(lootChest[i]);
                            lootChest.RemoveAt(i);
                            i--;
                        }
                    }

                   
                    Console.WriteLine(string.Join(", ",steal));
                }
                line = Console.ReadLine();
            }
            double countIntem = lootChest.Count;
            string length = "";
            foreach (var item in lootChest)
            {
                length += item;
            }
            double sum = length.Length / countIntem;
            if (sum>0)
            {
                Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits."); 
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
