using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Utilities.Messages;

namespace SantaWorkshop.Models.Dwarfs
{

    using SantaWorkshop.Models.Dwarfs.Contracts;
    using SantaWorkshop.Models.Instruments.Contracts;
    using SantaWorkshop.Utilities.Messages;
    public abstract class Dwarf : IDwarf
    {
        private const int EnergyToDecreese = 10;
        private string name;
        private int energy;

        protected Dwarf(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;

            this.Instruments = new List<IInstrument>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }

                this.name = value;
            }
        }
        public int Energy
        {
            get => energy;
            protected set { this.energy = value > 0 ? value : 0; }
        }
        public ICollection<IInstrument> Instruments { get; }
        public virtual void Work()
        {
            this.Energy -= EnergyToDecreese;
        }

        public void AddInstrument(IInstrument instrument)
        {
            this.Instruments.Add(instrument);
        }
    }
}
