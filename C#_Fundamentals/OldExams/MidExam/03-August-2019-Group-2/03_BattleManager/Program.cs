using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleHealt = new Dictionary<string, int>();
            var peopleEnergy = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Results")
                {
                    break;
                }

                if (input.Contains("Add"))
                {
                    string[] tokkens = input.Split(':');
                    string name = tokkens[1];
                    int health = int.Parse(tokkens[2]);
                    int energy = int.Parse(tokkens[3]);
                    if (!peopleHealt.ContainsKey(name))
                    {
                        peopleHealt[name] = health;
                        peopleEnergy[name] = energy;
                    }
                    else
                    {
                        peopleHealt[name] += health;
                    }
                }
                else if (input.Contains("Attack"))
                {
                    string[] tokkens = input.Split(':');
                    string attakerName = tokkens[1];
                    string defenderName = tokkens[2];
                    int damage = int.Parse(tokkens[3]);
                    if (peopleHealt.ContainsKey(attakerName) && peopleHealt.ContainsKey(defenderName))
                    {
                        peopleHealt[defenderName] -= damage;
                        peopleEnergy[attakerName]--;
                        if (peopleHealt[defenderName] <= 0)
                        {
                            peopleHealt.Remove(defenderName);
                            peopleEnergy.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        if (peopleEnergy[attakerName] == 0)
                        {
                            peopleHealt.Remove(attakerName);
                            peopleEnergy.Remove(attakerName);
                            Console.WriteLine($"{attakerName} was disqualified!");
                        }
                    }
                }
                else if (input.Contains("Delete"))
                {
                    string[] tokkens = input.Split(':');
                    string username = tokkens[1];
                    if (peopleHealt.ContainsKey(username))
                    {
                        peopleHealt.Remove(username);
                        peopleEnergy.Remove(username);
                    }
                    if (username == "All")
                    {
                        peopleEnergy.Clear();
                        peopleHealt.Clear();
                    }
                }
            }
            Console.WriteLine($"People count: {peopleHealt.Count}");
            peopleHealt = peopleHealt.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, k => k.Value);
            foreach (var person in peopleHealt)
            {
                Console.WriteLine($"{person.Key} - {person.Value} - {peopleEnergy[person.Key]}");
            }
        }
    }
}
