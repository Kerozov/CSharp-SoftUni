using System;
using System.Linq;
using System.Threading.Channels;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = person[0];
                int age = int.Parse(person[1]);
               
                    var member = new Person(name,age);
                    family.AddMember(member);
                
               
            } 

           family.PrintPerson();
        }
    }
}
