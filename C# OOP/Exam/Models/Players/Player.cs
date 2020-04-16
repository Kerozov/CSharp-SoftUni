using System;
using System.Text;
using System.Collections.Generic;

using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        public Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }

                this.username = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }

                this.health = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }

                this.armor = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return this.gun;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Gun cannot be null or empty.");
                }

                this.gun = value;
            }
        }


        public bool IsAlive => this.Health > 0;

        public void TakeDamage(int points)
        {
            if (this.armor > 0)
            {
                int difference = this.armor - points;
                if (difference < 0)
                {
                    int getFromHealth = points - this.armor;
                    this.armor -= points - getFromHealth;
                    this.health -= getFromHealth;

                    if (this.health < 0)
                    {
                        this.health = 0;
                    }
                }
                else
                {
                    this.armor -= points;
                }
            }
            else
            {
                this.health -= points;

                if (this.health < 0)
                {
                    this.health = 0;
                }
            }
        }
    }
}
