using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Repositories
{
   public class GunRepository:IRepository<IGun>
   {
       private ICollection<IGun> guns;

       public GunRepository()
       {
           guns = new List<IGun>();
       }
        public IReadOnlyCollection<IGun> Models
        {
            get => (IReadOnlyCollection<IGun>) guns;
        }
        public void Add(IGun model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }
            guns.Add(model);

        }

        public bool Remove(IGun model)
        {
            return guns.Remove(model);
        }

        public IGun FindByName(string name)
        {
            return guns.FirstOrDefault(g => g.Name == name);
        }
    }
}
