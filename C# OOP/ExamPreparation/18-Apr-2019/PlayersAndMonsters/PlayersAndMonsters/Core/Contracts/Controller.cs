using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core.Contracts
{
  public  class Controller:IManagerController
    {
        public string AddPlayer(string type, string username)
        {
            return TODO_IMPLEMENT_ME;
        }

        public string AddCard(string type, string name)
        {
            return TODO_IMPLEMENT_ME;
        }

        public string AddPlayerCard(string username, string cardName)
        {
            return TODO_IMPLEMENT_ME;
        }

        public string Fight(string attackUser, string enemyUser)
        {
            return TODO_IMPLEMENT_ME;
        }

        public string Report()
        {
            return TODO_IMPLEMENT_ME;
        }
    }
}
