using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BorderControl
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var destroyed = new List<IIdentifeable>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                     break;
                }

                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                if (commandArgs.Length==2)
                {
                   
                    string id = commandArgs[1];
                    var robot = new Robot(name,id);
                    destroyed.Add(robot);
                }
                else
                {
                    int year = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];
                    var person = new Person(name,year,id);
                    destroyed.Add(person);
                }
            }

            string number = Console.ReadLine();
            foreach (var curr in destroyed)
            {
                if (curr.IsDestryed(number,curr.Id)!=null)
                {
                    Console.WriteLine(curr.Id);
                }
            }
        }
    }
}
