using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;

namespace SpaceStation.Models.Mission
{
   public   class Mission:IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            IAstronaut astronaut;
            while (astronauts.Any(a=>a.CanBreath)&&planet.Items.Count>0)
            {
                astronaut = astronauts.First(a => a.CanBreath);
               astronaut.Breath();
                if (astronaut.CanBreath)
                {
                    var item = planet.Items.FirstOrDefault();
                    if (item!=null)
                    {
                        astronaut.Bag.Items.Add(item);
                        planet.Items.Remove(item);
                    }
                }
            }
        }
    }
}
