using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Repositories
{
  public  class CardRepository:ICardRepository
  {
      private readonly ICollection<ICard> cards;

      public CardRepository()
      {
          cards = new List<ICard>();
      }

        public int Count { get=>this.cards.Count; }
        public IReadOnlyCollection<ICard> Cards { get=>(IReadOnlyCollection<ICard>)cards; }
        public void Add(ICard card)
        {
            if (card==null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
            cards.Add(card);
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            return this.cards.Remove(card);
        }

        public ICard Find(string name)
        {
            return this.cards.FirstOrDefault(c => c.Name == name);
        }
    }
}
