using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var allHero = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var type = Console.ReadLine();
                if (type == "Druid")
                {
                    var druid = new Druid(name);
                    allHero.Add(druid);
                }
                else if (type == "Paladin")
                {
                    var paladin = new Paladin(name);
                    allHero.Add(paladin);
                }
                else if (type == "Rogue")
                {
                    var rogue = new Rogue(name);
                    allHero.Add(rogue);
                }
                else if (type == "Warrior")
                {
                    var warrior = new Warrior(name);
                    allHero.Add(warrior);
                }
                else
                {
                    i--;
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int heroPower = 0;
            foreach (var hero in allHero)
            {
                Console.WriteLine(hero.CastAbility());
                heroPower += hero.Power;
            }

            if (heroPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
