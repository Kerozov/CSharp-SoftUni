using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split()
                .ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] lines = Console.ReadLine().Split();
                string command = lines[0];
                if (command == "Include")
                {
                    string newShop = lines[1];
                    shops.Add(newShop);
                }
                else if (command == "Visit")
                {
                    string commandTwo = lines[1];
                    int count = int.Parse(lines[2]);

                    if (commandTwo == "first")
                    {
                        if (count <= shops.Count && count >= 0)
                        {
                            shops.RemoveRange(0, count);
                        }
                    }
                    else if (commandTwo == "last")
                    {
                        if (count <= shops.Count && count >= 0)
                        {
                            shops.Reverse();
                            shops.RemoveRange(0, count);
                            shops.Reverse();
                        }
                    }

                }
                else if (command == "Prefer")
                {
                    int indexOne = int.Parse(lines[1]);
                    int indexTwo = int.Parse(lines[2]);
                    if (indexOne >= 0 && indexTwo < shops.Count && indexTwo >= 0 && indexOne < shops.Count)
                    {
                        string oneValue = shops[indexOne];
                        shops[indexOne] = shops[indexTwo];
                        shops[indexTwo] = oneValue;
                    }
                }
                else if (command == "Place")
                {
                    string newItem = lines[1];
                    int index = int.Parse(lines[2]);
                    if (index + 1 >= 0 && index + 1 < shops.Count)
                    {
                        shops.Insert(index + 1, newItem);
                    }
                }

            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
