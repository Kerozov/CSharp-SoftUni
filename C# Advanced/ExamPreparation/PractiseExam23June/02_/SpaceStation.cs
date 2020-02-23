using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> data;
        private SpaceStation()
        {
            data = new List<Astronaut>();
        }
        public SpaceStation(string name, int capacity)
            :this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }
          
        public string Name { get; set; }
        public int 	Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity >= this.data.Count + 1)
            {
                data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            Astronaut astronaut = this.data
                .FirstOrDefault(a => a.Name == name);
            if (astronaut==null)
            {
                return false;
            }
            this.data.Remove(astronaut);
            return true;
        }
        public Astronaut GetOldestAstronaut()
        {
            return this.data
                .OrderByDescending(a => a.Age)
                .FirstOrDefault();   
        }
        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(a => a.Name == name);
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
