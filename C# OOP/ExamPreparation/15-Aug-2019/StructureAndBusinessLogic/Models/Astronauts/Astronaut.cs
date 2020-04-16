using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Models.Astronauts
{
   public abstract class Astronaut:IAstronaut
   {
       private string name;
       private double oxygen;
       private readonly IBag bag;
       protected Astronaut(string name, double oxygen)
       {
           this.Name = name;
           this.Oxygen = oxygen;
           bag = new Backpack();
       }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }

                this.name = value;
            }
        } 

        public double Oxygen
        {
            get => this.oxygen;
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }

                this.oxygen = value;
            }
        }

        public bool CanBreath
        {
            get
            {
                if (this.Oxygen>0)
                {
                    return true;
                }

                return false;
            }
        }

        public IBag Bag
        {
            get => bag;
        }
        public virtual void Breath()
        {
            var value = this.Oxygen - 10;
                this.Oxygen -= 10;
        }

        public override string ToString()
        {
            //Name: { astronautName}
            //Oxygen: { astronautOxygen}
            //Bag items: { bagItem1, bagItem2, …, bagItemn} / none
            var bagItem = this.Bag.Items.Count > 0 ? string.Join(", ", this.bag.Items):"none";
            
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Oxygen: {this.Oxygen}");
            sb.AppendLine($"Bag items: {bagItem}");
            return sb.ToString().TrimEnd();
        }
   }
}
