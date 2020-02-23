using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Christmas
{
    class Bag
    {
        private List<Present> data = new List<Present>();
        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
        }
        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Present present)
        {
            if (this.Capacity>=this.data.Count+1)
            {
                this.data.Add(present);
            }
        }
        public bool Remove(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
            if (present==null)
            {
                return false;
            }
            this.data.Remove(present);
            return true;
        }
        public Present GetHeaviestPresent()
        {
            return this.data.OrderByDescending(p => p.Weight).FirstOrDefault();
        }
        public Present GetPresent(string name)
        {
            return this.data.FirstOrDefault(p => p.Name == name);
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            data.OrderBy(p => p.Gender);
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
           return sb.ToString().TrimEnd();
        }
    }
}
