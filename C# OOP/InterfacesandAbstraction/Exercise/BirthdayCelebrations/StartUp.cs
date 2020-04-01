using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var destroyed = new List<IBirthable>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] commandArgs = command.Split();
                string parameter = commandArgs[0];
                if (parameter== "Citizen")
                {
                    string name = commandArgs[1];
                    int age = int.Parse(commandArgs[2]);
                    string id = commandArgs[3];
                    string bithDate = commandArgs[4];
                    IBirthable currBirthable = new Citizen(name,age,id, bithDate);
                    destroyed.Add(currBirthable);
                }
                else if (parameter =="Pet")
                {
                    string name = commandArgs[1];
                    string bithDate = commandArgs[2];
                    IBirthable iBirthable = new Pet(name, bithDate);
                    destroyed.Add(iBirthable);
                }
            }

            string year = Console.ReadLine();
            foreach (var curr in destroyed)
            {
                if (curr.IsCorrectYear(year, curr.Birthdate) != null)
                {
                    Console.WriteLine(curr.Birthdate);

                }
            }

        }
    }
}
