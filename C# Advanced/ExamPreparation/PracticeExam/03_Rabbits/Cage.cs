using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Rabbits
{
    public class Cage
    {
        private readonly List<Rabbit> rabbits = new List<Rabbit>();

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.rabbits.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.rabbits.Count + 1 <= this.Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = this.rabbits
                .FirstOrDefault(r => r.Name == name);
            if (rabbit != null)
            {
                this.rabbits.Remove(rabbit);
                return true;
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.rabbits.RemoveAll(r => r.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.rabbits
                .FirstOrDefault(r => r.Name == name);
            if (rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var arrayRabbits = this.rabbits
                .Where(r => r.Species == species)
                .ToArray();
            foreach (var rabbit in arrayRabbits)
            {
                rabbit.Available = false;
            }
            return arrayRabbits;
        }

        public string 	Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbit in rabbits.Where(r=>r.Available))
            {
                sb.AppendLine($"{rabbit}");
            }
            return sb.ToString().TrimEnd();

        }
    }
}
