using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using CounterStrike.Models;
using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.models;

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }

            this.models.Add(model);
        }

        public IGun FindByName(string name)
        {
            Gun gun = models.Where(x => x.Name == name)
                .FirstOrDefault() as Gun;

            return gun;
        }

        public bool Remove(IGun model) => this.models.Remove(model);
    }
}
