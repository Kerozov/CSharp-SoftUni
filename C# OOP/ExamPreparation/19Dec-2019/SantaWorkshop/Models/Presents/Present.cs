using System;
using System.Collections.Generic;
using System.Text;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Utilities.Messages;

namespace SantaWorkshop.Models.Presents
{

    using SantaWorkshop.Models.Presents.Contracts;
    using SantaWorkshop.Utilities.Messages;
    public class Present : IPresent
    {
        private string name;
        private int energyRequired;

        public Present(string name,int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPresentName);
                }

                name = value;
            }
        }

        public int EnergyRequired
        {
            get => this.energyRequired;
            private set { this.energyRequired = value > 0 ? value : 0; }
        }
        public void GetCrafted()
        {
            this.EnergyRequired -= 10;
        }
        public bool IsDone()
        {
           return this.EnergyRequired == 0;
        }
    }
}
