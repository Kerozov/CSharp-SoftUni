using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var VIPreservation = new HashSet<string>();
            var regularReservation = new HashSet<string>();
            bool isParty = false;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (isParty)
                {
                    VIPreservation.Remove(command);
                    regularReservation.Remove((command));
                    continue;
                }
                if (command == "PARTY")
                {

                    isParty = true;
                }
                else if (command.StartsWith("1") ||
                         command.StartsWith("2") ||
                         command.StartsWith("3") ||
                         command.StartsWith("4") ||
                         command.StartsWith("5") ||
                         command.StartsWith("6") ||
                         command.StartsWith("7") ||
                         command.StartsWith("8") ||
                         command.StartsWith("9"))
                     {

                        if (command.Length == 8)
                        {
                            VIPreservation.Add(command);
                        }
                     }
                else
                {
                    if (command.Length == 8)
                    {
                        regularReservation.Add(command);
                    }
                }
            }

            Console.WriteLine(VIPreservation.Count+regularReservation.Count);
            foreach (var people in VIPreservation)
            {
                Console.WriteLine(people);
            }

            foreach (var people in regularReservation)
            {
                Console.WriteLine(people);
            }
        }
    }
}
