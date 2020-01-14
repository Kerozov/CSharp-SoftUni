using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> statusPirateShip = Console.ReadLine()
                 .Split('>')
                 .Select(int.Parse)
                 .ToList();
            List<int> statusWarShip = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            int healthCapacity = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            bool isTrue = true;
            while (line != "Retire")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command == "Fire")
                {
                    int index = int.Parse(lines[1]);
                    int damage = int.Parse(lines[2]);
                       
                    if (index >= 0 && index < statusWarShip.Count)
                    {
                        statusWarShip[index] -= damage;

                        if (statusWarShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isTrue = false;
                            break;
                        }

                    }

                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(lines[1]);
                    int endIndex = int.Parse(lines[2]);
                    int damage = int.Parse(lines[3]);
                    if (startIndex >= 0 && endIndex < statusPirateShip.Count)
                    {
                     
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int result = statusPirateShip[i];
                            result = statusPirateShip[i] - damage;
                            

                            if (result <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isTrue = false;
                                break;
                            }
                            else
                            {
                                statusPirateShip[i] = result;
                            }
                        }
                       
                    }
                   
                }
                else if (command == "Repair")
                {

                    int index = int.Parse(lines[1]);
                    int healt = int.Parse(lines[2]);
                    if (index >= 0 && index < statusPirateShip.Count)
                    {
                        healt += statusPirateShip[index];
                        if (healt <= healthCapacity)
                        {
                            statusPirateShip[index] = healt;

                        }
                        else
                        {
                            statusPirateShip[index] = healthCapacity;
                        }
                    }
                    
                }
                else if (command == "Status")
                {
                    int repairs = 0;
                    for (int i = 0; i < statusPirateShip.Count; i++)
                    {
                        double current = 0.2*healthCapacity;
                        if (current>statusPirateShip[i])
                        {
                            repairs++;
                        }
                    }
                    Console.WriteLine($"{repairs} sections need repair.");
                }

                line = Console.ReadLine();
            }
            if (isTrue)
            {


                int sumPirateShip = 0;
                int sumWarShip = 0;
                foreach (var i in statusPirateShip)
                {
                    sumPirateShip += i;
                }
                foreach (var i in statusWarShip)
                {
                    sumWarShip += i;
                }
                Console.WriteLine($"Pirate ship status: {sumPirateShip}");
                Console.WriteLine($"Warship status: {sumWarShip}");
            }
        }
    }
}
