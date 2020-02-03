using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _05_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var info = new List<PersonInfo>();
            for (int i = 0; i < n; i++)
            {
                var infoPerson = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = infoPerson[0];
                var year = int.Parse(infoPerson[1]);
                info.Add(new PersonInfo
                {
                    Name = name,
                    Age = year

                });

            }




            string lowerUppper = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<PersonInfo, bool> myFunc = lowerUppper switch
            {
                "older" => x => x.Age >= age,
                "younger" => x => x.Age <= age,
                _ => x => true
            };

            Func<PersonInfo, string> output = format switch
            {
                "name" =>p=> $"{p.Name}",
                "name age" =>p=> $"{p.Name} - {p.Age}",
                "age" =>p=>$"{p.Age}"

            };

             info.Where(myFunc)
                .Select(output)
                .ToList()
                .ForEach(Console.WriteLine);

        }

    }
    namespace _05_FilterByAge
    {
        class PersonInfo
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

