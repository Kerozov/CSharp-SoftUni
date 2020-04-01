using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FoodShortage
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var destroyed = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (command.Length==4)
                {
                    //Citizen
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    string id = command[2];
                    string bithDate = command[3];
                    IBuyer currCitizen = new Citizen(name, age, id, bithDate);
                    destroyed.Add(currCitizen);
                }
                else
                {
                    //Rabel
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    string group = command[2];
                    IBuyer currRabel = new Rebel(name,age,group);

                    destroyed.Add(currRabel);

                }
            }

            int totalAmount =0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                foreach (var curr in destroyed)
                {
                    curr.BuyFood(command);
                }
            }

            foreach (var curr in destroyed)
            {
                totalAmount+=curr.Food;
            }

            Console.WriteLine(totalAmount);
        }
    }
}
