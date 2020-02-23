using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace DefiningClasses
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person Name)
        {
            members.Add(Name);
        }

        public string GetOlderMember()
        {
            return this.members.OrderByDescending(p => p.Age).FirstOrDefault().ToString();
        }

        public void PrintPerson()
        {
            members = members.OrderBy(p => p.Name).ToList();
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Age>=30)
                {
                    Console.WriteLine($"{members[i].Name} - {members[i].Age}");
                }
            }

            
        }
    }
}
