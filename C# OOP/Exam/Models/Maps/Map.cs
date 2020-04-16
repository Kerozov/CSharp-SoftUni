using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public Map()
        {
        }

        public string Start(ICollection<IPlayer> players)
        {
            List<IPlayer> terrorists = players.Where(x => x.GetType().Name == "Terrorist").ToList();

            List<IPlayer> counterTerrorists = players.Where(x => x.GetType().Name == "CounterTerrorist").ToList();


            while (terrorists.Any(x => x.IsAlive)
                && counterTerrorists.Any(x => x.IsAlive))
            {
                foreach (var terrorist in terrorists)
                {
                    if (terrorist.IsAlive)
                    {
                        foreach (var counter in counterTerrorists)
                        {
                            if (counter.IsAlive)
                            {
                                int bullets = terrorist.Gun.Fire();
                                counter.TakeDamage(bullets);
                            }
                        }
                    }
                }

                foreach (var counter in counterTerrorists)
                {
                    if (counter.IsAlive)
                    {
                        foreach (var terrorist in terrorists)
                        {
                            if (terrorist.IsAlive)
                            {
                                int bullets = counter.Gun.Fire();
                                terrorist.TakeDamage(bullets);
                            }
                        }
                    }
                }
            }

            if (counterTerrorists.Any(x => x.IsAlive))
            {
                return "CounterTerrorist wins!";
            }
            return "Terrorist wins!";
        }
    }
}
