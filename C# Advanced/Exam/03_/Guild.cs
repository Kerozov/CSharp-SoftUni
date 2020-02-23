using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Guild
{
    class Guild
    {
        private List<Player> roster = new List<Player>();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }
        public void AddPlayer(Player player)
        {
            if (this.Capacity >= roster.Count + 1)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            if (player == null)
            {
                return false;
            }
            roster.Remove(player);
            return true;
        }
        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Member")
            {
                for (int i = 0; i < roster.Count; i++)
                {
                    if (roster[i] == player)
                    {
                        roster[i].Rank = "Member";
                        break;
                    }
                }

            }

        }
        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Trial")
            {
                for (int i = 0; i < roster.Count; i++)
                {
                    if (roster[i] == player)
                    {
                        roster[i].Rank = "Trial";
                        break;
                    }
                }

            }
        }
        public Player[] KickPlayersByClass(string clas)
        {
            List<Player> playersOfClass = new List<Player>();
            playersOfClass = roster.Where(p => p.Class == clas).ToList();
            foreach (var player in playersOfClass)
            {
                roster.Remove(player);
            }
            return playersOfClass.ToArray();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
