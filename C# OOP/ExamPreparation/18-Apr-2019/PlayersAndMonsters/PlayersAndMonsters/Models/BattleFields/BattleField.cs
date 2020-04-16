using System;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;

namespace PlayersAndMonsters.Models.BattleFields
{
   public class BattleField :IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            IsDeadUser(attackPlayer, enemyPlayer);
            if (attackPlayer.GetType().Name=="Beginner")
            {
                attackPlayer.Health += 40;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
            else if (enemyPlayer.GetType().Name == "Beginner")
            {
                enemyPlayer.Health += 40;
                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            foreach (var card in attackPlayer.CardRepository.Cards)
            {
                attackPlayer.Health += card.HealthPoints;
            }
            foreach (var card in enemyPlayer.CardRepository.Cards)
            {
                enemyPlayer.Health += card.HealthPoints;
            }
            while (true)
            {
               
                foreach (var cardOnAttacker in attackPlayer.CardRepository.Cards)
                {
                    enemyPlayer.TakeDamage(cardOnAttacker.DamagePoints);
                }
                bool isDeadAtttacker = attackPlayer.IsDead;
                bool isDeadEnemt = enemyPlayer.IsDead;
                if (isDeadEnemt || isDeadAtttacker)
                {
                    break;
                }
                foreach (var cardOnEnemy in enemyPlayer.CardRepository.Cards)
                {
                    attackPlayer.TakeDamage(cardOnEnemy.DamagePoints);
                }
                 isDeadAtttacker = attackPlayer.IsDead;
                 isDeadEnemt = enemyPlayer.IsDead;
                if (isDeadEnemt || isDeadAtttacker)
                {
                    break;
                }
            }
        }

        private static void IsDeadUser(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            bool isDeadAtttacker = attackPlayer.IsDead;
            bool isDeadEnemt = enemyPlayer.IsDead;
            if (isDeadEnemt || isDeadAtttacker)
            {
                throw new ArgumentException("Player is dead!");
            }
        }
    }
}
