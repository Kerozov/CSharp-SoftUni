using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Utilities.Messages;

namespace SantaWorkshop.Models.Dwarfs
{
    public abstract class Dwarf : IDwarf
    {
        private const int EnergyToDecreese = 10;
        private string name;
        private int energy;
        private ICollection<IInstrument> instruments;

        private Dwarf()
        {
            instruments = new List<IInstrument>();
        }
        protected Dwarf(string name,int energy)
        :this()
        {
            this.Name = name;
            this.Energy = energy;
        }

        public string Name
        {
            get => name;
            set
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
            protected set
            {
                if (value<0)
                {
                    this.energy = 0;
                }

                this.energy = value;
            }
        }
        public ICollection<IInstrument> Instruments
        {
            get => instruments;
        }
        public virtual void Work()
        {
            this.Energy -= EnergyToDecreese;
        }

        public void AddInstrument(IInstrument instrument)
        {
            this.instruments.Add(instrument);
        }

        
    }
}
