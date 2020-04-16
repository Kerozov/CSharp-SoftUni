using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;

namespace CounterStrike.Models.Maps
{
   public class Map:IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            ICollection<IPlayer> terrorists = new List<IPlayer>();
            ICollection<IPlayer> counterterrorists = new List<IPlayer>();

            bool ctLose = false;
            bool tLose = false;
            foreach (var player in players)
            {
                if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
                else
                {
                    counterterrorists.Add(player);
                }
            }
            while (terrorists.Any(t=>t.IsAlive)&&counterterrorists.Any(ct=>ct.IsAlive))
            {
                terrorists = terrorists.Where(t => t.IsAlive).ToList();
                counterterrorists = counterterrorists.Where(t => t.IsAlive).ToList();


                    foreach (var ct in counterterrorists)
                    {
                        ct.TakeDamage(terrorists.First(t=>t.IsAlive).Gun.Fire());
                        terrorists.Remove(terrorists.First(t => t.IsAlive));
                    }
                    if (!terrorists.Any(t => t.IsAlive))
                    {
                        tLose = true;
                        break;
                    }
                    if (!counterterrorists.Any(t => t.IsAlive))
                    {
                        ctLose = true;
                        break;
                    }

                    if (tLose || ctLose)
                    {
                        break;
                    }
                    terrorists.Add(terrorists.First(t => t.IsAlive));

                    foreach (var t in terrorists)
                    {
                        t.TakeDamage(counterterrorists.First(t => t.IsAlive).Gun.Fire());
                        counterterrorists.Remove(counterterrorists.First(t => t.IsAlive));
                    }
                    counterterrorists.Add(counterterrorists.First(t => t.IsAlive));


                    if (!terrorists.Any(t=>t.IsAlive))
                    {
                        tLose = true;
                        break;
                    }
                    if (!counterterrorists.Any(t => t.IsAlive))
                    {
                        ctLose = true;
                        break;
                    }

                    if (tLose||ctLose)
                    {
                        break;
                    }
                    
            }

            if (tLose)
            {
                return "Counter Terrorist wins!";
            }
            else
            {
                return "Terrorist wins!";
            }
        }
    }
}
