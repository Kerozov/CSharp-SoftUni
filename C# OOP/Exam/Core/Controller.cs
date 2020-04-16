using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using CounterStrike.Models;
using CounterStrike.Models.Maps;
using CounterStrike.Repositories;
using CounterStrike.Core.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;

        public Controller()
        {
            this.guns = new GunRepository();
            this.players = new PlayerRepository();
            this.map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            if (type == "Pistol")
            {
                Pistol pistol = new Pistol(name, bulletsCount);

                guns.Add(pistol);

                return string.Format(OutputMessages.SuccessfullyAddedGun, name);
            }
            else if (type == "Rifle")
            {
                Rifle rifle = new Rifle(name, bulletsCount);

                guns.Add(rifle);

                return string.Format(OutputMessages.SuccessfullyAddedGun, name);
            }

            throw new ArgumentException(ExceptionMessages.InvalidGunType);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            Gun gun = guns.FindByName(gunName) as Gun;

            if (gun == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            if (type == "Terrorist")
            {
                Terrorist terrorist = new Terrorist(username, health, armor, gun);

                this.players.Add(terrorist);
                return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
            }
            else if (type == "CounterTerrorist")
            {
                CounterTerrorist counter = new CounterTerrorist(username, health, armor, gun);

                this.players.Add(counter);
                return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }
        }

        public string Report()
        {
            List<IPlayer> playersReport = players.Models.ToList();

            playersReport = playersReport
                .OrderBy(x => x.GetType().Name)
                .ThenByDescending(h => h.Health)
                .ThenBy(u => u.Username)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var player in playersReport)
            {
                sb.AppendLine($"{player.GetType().Name}: {player.Username}");
                sb.AppendLine($"--Health: {player.Health}");
                sb.AppendLine($"--Armor: {player.Armor}");
                sb.AppendLine($"--Gun: {player.Gun.Name}");
            }

            return sb.ToString().TrimEnd();
        }

        public string StartGame() => map.Start(players.Models.ToList());

    }
}
