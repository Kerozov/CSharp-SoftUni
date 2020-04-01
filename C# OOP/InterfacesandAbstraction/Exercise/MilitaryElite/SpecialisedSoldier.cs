using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier:ISpecialisedSoldier
    {
        public string Corps { get;  set; }
        public string Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public decimal Salary { get;  set; }
    }
}
