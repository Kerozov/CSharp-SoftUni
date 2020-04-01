using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private:IPrivate
    {
        public Private(string id,string firstName,string lastName,decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
        public decimal Salary { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
        }
    }
}
