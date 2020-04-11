using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;

namespace SantaWorkshop.Repositories.Contracts
{
    using SantaWorkshop.Models.Dwarfs;
    using SantaWorkshop.Models.Dwarfs.Contracts;
    public class DwarfRepository :IRepository<IDwarf>
   {
       private readonly ICollection<IDwarf> models ;

       public DwarfRepository()
       {
           models = new List<IDwarf>();
       }
       public IReadOnlyCollection<IDwarf> Models
        {
            get => (IReadOnlyCollection<IDwarf>)this.models;
        }
        public void Add(IDwarf model)
        {
            models.Add(model);
        }

        public bool Remove(IDwarf model)
        {
            return models.Remove(model);
        }

        public IDwarf FindByName(string name)
        {
            return models.FirstOrDefault(i => i.Name == name);
        }
    }
}
