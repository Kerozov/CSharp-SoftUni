using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Repositories.Contracts;

namespace SantaWorkshop.Repositories
{
  public  class PresentRepository :IRepository<Present>
  {
      private ICollection<Present> presents;
        public IReadOnlyCollection<Present> Models { get; }
        public void Add(Present present)
        {
            this.presents.Add(present);
        }

        public bool Remove(Present present)
        {
            return presents.Remove(present);
        }

        public Present FindByName(string name)
        {
            return presents.FirstOrDefault(p => p.Name == name);
        }
    }
}
