using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;

namespace SantaWorkshop.Repositories.Contracts
{
   public class DwarfRepository :IRepository<Dwarf>
   {
       private ICollection<Dwarf> models;
        public IReadOnlyCollection<Dwarf> Models
        {
            get => (IReadOnlyCollection<Dwarf>)this.models;
        }
        public void Add(Dwarf dwarf)
        {
            models.Add(dwarf);
        }

        public bool Remove(Dwarf dwarf)
        {
            return models.Remove(dwarf);
        }

        public Dwarf FindByName(string name)
        {
            return models.FirstOrDefault(i => i.Name == name);
        }
    }
}
