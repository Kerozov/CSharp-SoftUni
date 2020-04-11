using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;

namespace SantaWorkshop.Models.Workshops
{

    using SantaWorkshop.Models.Dwarfs.Contracts;
    using SantaWorkshop.Models.Instruments.Contracts;
    using SantaWorkshop.Models.Presents.Contracts;
    using SantaWorkshop.Models.Workshops.Contracts;
    public class Workshop : IWorkshop
    {
        public Workshop()
        {
            
        }
        public void Craft(IPresent present, IDwarf dwarf)
        {
            
            while (dwarf.Energy > 0 && dwarf.Instruments.Any())
            {
                IInstrument currInstrument = dwarf.Instruments.First();
                while (!present.IsDone() && dwarf.Energy > 0 && !currInstrument.IsBroken())
                {
                    dwarf.Work();
                    present.GetCrafted();
                    currInstrument.Use();
                }

                if (currInstrument.IsBroken())
                {
                    dwarf.Instruments.Remove(currInstrument);
                }

                if (present.IsDone())
                {
                    break;
                }
            }

            //public void Craft(IPresent present, IDwarf dwarf)
            //{
            //    var currInstrument = dwarf.Instruments.FirstOrDefault(i => !(i.IsBroken()));
            //    if (dwarf.Energy > 0 && currInstrument != null)
            //    {
            //        dwarf.Work();
            //        present.GetCrafted();
            //        currInstrument.Use();
            //    }

            //    if (!present.IsDone() && dwarf.Energy > 0 && dwarf.Instruments.Any())
            //    {
            //        this.Craft(present, dwarf);
            //    }
            //}
        }
    }
}

