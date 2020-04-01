using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MilitaryElite
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var privates = new List<Private>();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string member = command[0];
                if (member=="End")
                {
                    break;
                }
                string id = command[1];
                string firstName = command[2];
                string lastName = command[3];
                if (member == "Private")
                {
                    decimal salary = decimal.Parse(command[4]);
                    var privateMember = new Private(id, firstName, lastName, salary);
                    Console.WriteLine(privateMember);
                    privates.Add(privateMember);
                }
                else if (member == "LieutenantGeneral")
                {
                    var privateIds = new List<string>();
                    decimal salary = decimal.Parse(command[4]);
                    foreach (var privateId in command.Skip(4))
                    {
                        privateIds.Add(privateId);
                    }

                    var lieutenantGeneral =
                        new LieutenantGeneral(id, firstName, lastName, salary, privateIds, privates);
                    Console.WriteLine(lieutenantGeneral);
                }
                else if (member == "Engineer")
                {
                    var repairs = new List<Repair>();
                    decimal salary = decimal.Parse(command[4]);
                    string corps = command[5];
                    if (corps!= "Airforces"&&corps!= "Marines")
                    {
                        continue;
                    }
                    for (int i = 6; i < command.Length-1; i+=2)
                    {
                        var repair = new Repair(command[i],int.Parse(command[i+1]));
                        repairs.Add(repair);
                    }
                    var engeener = new Engineer(id,firstName,lastName,salary,corps,repairs);
                    Console.WriteLine(engeener);
                }
                else if (member == "Commando")
                {
                    var missions = new List<Mission>();
                    decimal salary = decimal.Parse(command[4]);
                    string corps = command[5];
                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }
                    for (int i = 6; i < command.Length - 1; i+=2)
                    {
                        string codeName = command[i];
                        string state = command[i + 1];
                        if (state=="Finished"||state== "inProgress")
                        {
                            var mission = new Mission(codeName,state);
                            missions.Add(mission);
                        }
                    }
                    var commando = new Commando(id,firstName,lastName,salary,corps,missions);
                    Console.WriteLine(commando);
                }
                else if (member == "Spy")
                {
                    int codeNumber = int.Parse(command[4]);
                    var spy = new Spy(id,firstName,lastName,codeNumber);
                    Console.WriteLine(spy);
                }

            }
        }
    }
}
