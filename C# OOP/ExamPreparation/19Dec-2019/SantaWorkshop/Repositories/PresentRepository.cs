using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Repositories.Contracts;

namespace SantaWorkshop.Repositories
{

    using SantaWorkshop.Models.Presents;
    using SantaWorkshop.Models.Presents.Contracts;
    using SantaWorkshop.Repositories.Contracts;
    public class PresentRepository : IRepository<IPresent>
    {
        private readonly ICollection<IPresent> models ;

        public PresentRepository()
        {
            models = new List<IPresent>();
        }
        public IReadOnlyCollection<IPresent> Models
        {
            get => (IReadOnlyCollection<IPresent>)this.models;
        }

        public void Add(IPresent model)
        {
            this.models.Add(model);
        }

        public bool Remove(IPresent model)
        {
            return models.Remove(model);
        }

        public IPresent FindByName(string name)
        {
            return models.FirstOrDefault(p => p.Name == name);
        }
    }
}
