using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            var userlMeals = new Dictionary<string, List<string>>();
            var unlikeMeal = 0;
            //input and logic
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }

                if (command.Contains("Like"))
                {
                    string[] tokkens = command.Split('-');
                    string user = tokkens[1];
                    string meal = tokkens[2];
                    if (!userlMeals.ContainsKey(user))
                    {
                        userlMeals[user] = new List<string>();
                    }
                    if (userlMeals[user].Contains(meal))
                    {
                        continue;
                    }
                    userlMeals[user].Add(meal);
                }
                else if (command.Contains("Unlike"))
                {
                    string[] tokkens = command.Split('-');
                    string user = tokkens[1];
                    string meal = tokkens[2];
                    if (!userlMeals.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} is not at the party.");
                        continue;
                    }
                    if (!userlMeals[user].Contains(meal))
                    {
                        Console.WriteLine($"{user} doesn't have the {meal} in his/her collection.");
                        continue;
                    }
                    Console.WriteLine($"{ user} doesn't like the {meal}.");
                    unlikeMeal++;
                    userlMeals[user].Remove(meal);
                }
            }
            //output
            var ordered = userlMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            foreach (var guest in ordered)
            {
                
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: { unlikeMeal}");
        }
    }
}
