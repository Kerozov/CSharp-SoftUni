using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using CounterStrike.Models.Players;
using CounterStrike.Utilities.Messages;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly List<IPlayer> models;

        public PlayerRepository()
        {
            this.models = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => this.models;

        public void Add(IPlayer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            this.models.Add(model);
        }

        public IPlayer FindByName(string name)
        {
            Player player = models.Where(x => x.Username == name).FirstOrDefault() as Player;

            return player;
        }

        public bool Remove(IPlayer model) => this.models.Remove(model);
    }
}
