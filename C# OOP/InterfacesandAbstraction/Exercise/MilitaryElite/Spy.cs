using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
   public class Spy:ISpy
    {
         public Spy(string id, string firstName, string lastName,int codeNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = codeNumber;
        }
        public int CodeNumber { get;  set; }
        public string Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}\r\nCode Number: {CodeNumber}";
        }
    }
}
