using System;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
   public class Beginner:Player
    {
        public Beginner(ICardRepository cardRepository, string username) : base(cardRepository, username, 50)
        {

        }
    }
}
