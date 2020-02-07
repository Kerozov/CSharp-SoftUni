using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;

namespace _10_PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split()
                .ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                var cmdArgs = command.Skip(1).ToArray();
                Predicate<string> predicate;

                if (command[0] == "Party!")
                {
                    break;
                }

                if (command[0] == "Double")
                {
                    predicate = GetPredicate(cmdArgs);
                    for (int i = 0; i < names.Count; i++)
                    {
                        string currentName = names[i];
                        if (predicate(currentName))
                        {
                            names.Insert(i+1, currentName);
                           i++;
                        }
                    }

                }
                else if (command[0] == "Remove")
                {
                    predicate = GetPredicate(cmdArgs);
                    names.RemoveAll(predicate);
                }
            }

            if (names.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ",names)+ " are going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string[] command)
        {
            string type = command[0];
            string agrument = command[1];
            Predicate<string> predicate = null;
            if (type == "StartsWith")
            {
                predicate = new Predicate<string>(s => { return s.StartsWith(agrument); });
            }
            else if (type == "EndsWith")
            {
                predicate = new Predicate<string>(name => { return name.EndsWith(agrument); });
            }
            else if (type == "Length")
            {
                predicate = new Predicate<string>(s =>
                {
                    return s.Length == int.Parse(agrument);
                });
            }

            return predicate;
        }

    }
}
