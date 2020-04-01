using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
   public class Engineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary,string corps,List<Repair>repairs) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.Repairs = repairs;
        }
        public List<Repair> Repairs { get; set; }
        public string Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public decimal Salary { get;  set; }
        public string Corps { get;  set; }
        public override string ToString()
        {
           var sb = new StringBuilder();
           sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
           sb.AppendLine($"Corps: {Corps}");
           sb.AppendLine($"Repairs:");
           foreach (var repairName in Repairs)
           {
               sb.AppendLine($" {repairName.ToString()}");
           }

           return sb.ToString().TrimEnd();
        }
    }
}
