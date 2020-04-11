using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Repositories;
using SantaWorkshop.Repositories.Contracts;
using SantaWorkshop.Utilities.Messages;

namespace SantaWorkshop.Core
{
    class Controller :IController
    {
        private DwarfRepository dwarfs;
        private PresentRepository presents;
        public Controller()
        {
            dwarfs = new DwarfRepository();
            presents = new PresentRepository();
        }
        public string AddDwarf(string dwarfType, string dwarfName)
        {
            IDwarf dwarf = null;
            if (dwarfType=="HappyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if (dwarfType == "SleepyDwarf")
            {
                dwarf = new SleepyDwarf(dwarfName);
            }

            if (dwarf!=null)
            {
                dwarfs.Add(dwarf);
                return string.Format(OutputMessages.DwarfAdded,dwarfType,dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            IDwarf dwarf = dwarfs.FindByName(dwarfName);
            if (dwarf!=null)
            {
                dwarf.AddInstrument(new Instrument(power));
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }

            return
                string.Format(OutputMessages.InstrumentAdded,power,dwarfName);
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            presents.Add(new Present(presentName,energyRequired));
            return string.Format(OutputMessages.PresentAdded,presentName);
        }

        public string CraftPresent(string presentName)
        {
            Workshop workShop = new Workshop();
            IPresent present = presents.FindByName(presentName);
            ICollection<IDwarf> dwarves = dwarfs
                .Models
                .Where(dw => dw.Energy >= 50)
                .OrderByDescending(dw => dw.Energy)
                .ToList();
            if (!dwarves.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }

            while (dwarves.Any())
            {
                IDwarf currDwarf = dwarves.First();
                workShop.Craft(present,currDwarf);
                if (!currDwarf.Instruments.Any())
                {
                    dwarves.Remove(currDwarf);
                }
                if (currDwarf.Energy==0)
                {
                    dwarves.Remove(currDwarf);
                    dwarfs.Remove(currDwarf);
                }
                if (present.IsDone())
                {
                    break;
                }
            }

            return string.Format(present.IsDone() ? OutputMessages.PresentIsDone : OutputMessages.PresentIsNotDone,
                presentName);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{presents.Models.Count(p => p.IsDone())} presents are done!");
            sb.AppendLine("Dwarfs info:");
            foreach (var dwarf in dwarfs.Models)
            {
                sb.AppendLine($"Name: {dwarf.Name}");
                sb.AppendLine($"Energy: {dwarf.Energy}");
                sb.AppendLine($"Instruments: {dwarf.Instruments.Count(i => !i.IsBroken())} not broken left");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
