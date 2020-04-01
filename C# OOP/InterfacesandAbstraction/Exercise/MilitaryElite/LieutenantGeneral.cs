using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
   public class LieutenantGeneral :ILieutenantGeneral
    {
        public LieutenantGeneral(string id,string firstName,string lastName,decimal salary,List<string> privetsId,List<Private>privates )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.PrivatesId = privetsId;
            this.Privates = privates;
        }
        public List<string> PrivatesId { get;  set; }
        public List<Private> Privates { get; set; }
        public string Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public decimal Salary { get;  set; }
        public override string ToString()
        {
            var sb= new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}\r\nPrivates:");
            foreach (var curr in PrivatesId)
            {
                for (int i = 0; i < Privates.Count; i++)
                {
                    if (curr == Privates[i].Id&&curr!=null)
                    {
                        sb.AppendLine(Privates[i].ToString());
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}
