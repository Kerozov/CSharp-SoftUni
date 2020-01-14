using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sides = new Dictionary<string, List<string>>();
            var users = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] tokens = input.Split(new[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains('|'))
                {
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!users.ContainsKey(user))
                    {
                        users[user] = side;
                        if (!sides.ContainsKey(side))
                        {
                            sides[side] = new List<string>();
                        }
                        if (!sides[side].Contains(user))
                        {
                            sides[side].Add(user);
                        }
                    }
                    
                }
                else
                {
                    string side = tokens[1];
                    string user = tokens[0];
                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, side);
                        if (!sides.ContainsKey(side))
                        {
                            sides[side] = new List<string>();
                        }
                        sides[side].Add(user);
                    }
                    else
                    {
                        string oldSide = users[user];
                        sides[oldSide].Remove(user);
                        if (!sides.ContainsKey(side))
                        {
                            sides[side] = new List<string>();
                        }
                        sides[side].Add(user);
                        users[user] = side;
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }

            }
            foreach (var side in sides.Where(s => s.Value.Count > 0).OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var u in side.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {u}");
                }
            }
        }
    }
}
