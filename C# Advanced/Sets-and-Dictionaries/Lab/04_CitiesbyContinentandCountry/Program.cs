using System;
using System.Collections.Generic;

namespace _04_CitiesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string,Dictionary<string,List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string,List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country,new List<string>());
                }
                    continents[continent][country].Add(city);
                

            }

            foreach (var ( key,value) in continents)
            {
                Console.WriteLine($"{key}:");
                foreach (var (country,city) in value)
                {
                    Console.WriteLine($"{country} -> {string.Join(", ",city)}");
                }
            }
        }
    }
}
