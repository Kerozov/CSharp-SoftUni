using System;
using System.Collections.Generic;

namespace _05_TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split('-');
                var team = new Team();
                
                team.user = info[0];
                team.nameTeam = info[1];
                Console.WriteLine($"Team {team.nameTeam} has been created by {team.user}");
                teams.Add(team);
            }
            string line = Console.ReadLine();
            while (line != "end of assignment")
            {
                string[] memberJoin = line.Split("->");
                string member = memberJoin[0];
                string teamName = memberJoin[1];
                int count = 0;
                foreach (var t in teams)
                {
                    if ()
                    {
                        if (t.nameTeam == teamName)
                        {
                            t.count++;
                            count++;
                        }
                    }
                }
                line = Console.ReadLine();
            }

        }
    }
}
