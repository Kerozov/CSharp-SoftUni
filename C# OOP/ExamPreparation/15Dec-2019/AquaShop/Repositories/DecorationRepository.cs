using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;

namespace AquaShop.Models.Aquariums
{
   public class DecorationRepository:IRepository<IDecoration>
   {
       private ICollection<IDecoration> models;

       public DecorationRepository()
       {
           this.models = new List<IDecoration>();
       }
        public IReadOnlyCollection<IDecoration> Models
        {
            get => (IReadOnlyCollection<IDecoration>) this.models;
        }
        public void Add(IDecoration model)
        { 
            this.models.Add(model);
        }

        public bool Remove(IDecoration model)
        {
            return this.models.Remove(model);
        }

        public IDecoration FindByType(string type)
        {
            return this.models.FirstOrDefault(d => d.GetType().Name == type);
        }
    }
}
