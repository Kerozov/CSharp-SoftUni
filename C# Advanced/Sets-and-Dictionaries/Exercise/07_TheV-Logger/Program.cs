using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07_TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlogerFollowers = new Dictionary<string, HashSet<string>>();
            var vlogerFollowings = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Statistics")
                {
                    break;
                }

                var input = command.Split();
                var vloger = input[0];
                if (input[1] == "joined")
                {
                    if (!vlogerFollowers.ContainsKey(vloger))
                    {
                        vlogerFollowers.Add(vloger, new HashSet<string>());
                        vlogerFollowings.Add(vloger, new HashSet<string>());
                    }
                }

                if (input[1] == "followed")
                {
                    var secondVloger = input[2];
                    if (!vlogerFollowers.ContainsKey(vloger) || !vlogerFollowers.ContainsKey(secondVloger))
                    {
                        continue;
                    }

                    if (vloger == secondVloger)
                    {
                        continue;
                    }

                    vlogerFollowings[vloger].Add(secondVloger);
                    vlogerFollowers[secondVloger].Add(vloger);
                }
            }

            vlogerFollowers = vlogerFollowers.OrderByDescending(x => x.Value.Count)
                .ThenBy(x=> vlogerFollowings[x.Key].Count)
                .ToDictionary(x => x.Key, z => z.Value);
            
            Console.WriteLine($"The V-Logger has a total of {vlogerFollowers.Keys.Count} vloggers in its logs.");
            var count = 0;
            foreach (var (key, value) in vlogerFollowers)
            {
                
                Console.WriteLine($"{++count}. {key} : {value.Count} followers, {vlogerFollowings[key].Count} following");
                var followers = value.OrderBy(x => x).ToHashSet();
                if (count==1)
                {
                    foreach (var follower in followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
