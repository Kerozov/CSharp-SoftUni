using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Core
{
  public  class Controller:IController
  {
      private GunRepository guns;
      private PlayerRepository players;
      private IMap map;
        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map  =new Map();
        }
        public string AddGun(string type, string name, int bulletsCount)
        {
            if (type== "Pistol")
            {
                guns.Add(new Pistol(name,bulletsCount));
            }
            else if (type== "Rifle")
            {
                guns.Add(new Rifle(name, bulletsCount));
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            return String.Format(OutputMessages.SuccessfullyAddedGun,name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = guns.FindByName(gunName);
            if (gun==null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }
            if (type == "Terrorist")
            {

              players.Add(new Terrorist(username,health,armor,gun));
            }
            else if (type == "CounterTerrorist")
            {
                players.Add(new CounterTerrorist(username, health, armor, gun));
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            return String.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string StartGame()
        {
           return map.Start(players.Models.ToArray());
        }

        public string Report()
        {
            var sb = new StringBuilder();
            var oredersedPlayers = players.Models.OrderBy(p => p.GetType().Name).ThenByDescending(p => p.Health)
                .ThenBy(p => p.Username);
            foreach (var player in oredersedPlayers)
            { 
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
