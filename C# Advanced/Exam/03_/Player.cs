using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {
        public string  Name { get; set; }
        public string  Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";
        public Player(string name,string clas)
        {
            this.Class = clas;
            this.Name = name;
        }
        public override string ToString()
        {
            return  $"Player {Name}: {Class}{Environment.NewLine}Rank: { Rank}{Environment.NewLine}Description: {Description}"
;
        }
    }
}
