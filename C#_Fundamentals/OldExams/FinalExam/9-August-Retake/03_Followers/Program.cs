using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary
            var followersLike = new Dictionary<string, int>();
            var followersComment = new Dictionary<string,int>();

            //input and logic
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Log out")
                {
                    break;
                }

                if (command.Contains("New follower"))
                {
                    string[] tokkens = command.Split();
                    string username = tokkens[2];
                    if (!followersComment.ContainsKey(username))
                    {
                        followersComment[username] = 0;
                        followersLike[username] = 0;
                    }
                }
                else if (command.Contains("Like"))
                {
                    string[] tokkens = command.Split();
                    string username = tokkens[1];
                    username = username.Remove(username.Length-1);
                    int count = int.Parse(tokkens[2]);
                    if (!followersLike.ContainsKey(username))
                    {
                        followersComment[username] = 0;
                        followersLike[username] = 0;
                    }
                    followersLike[username] += count;
                }
                else if (command.Contains("Comment"))
                {
                    string[] tokkens = command.Split();
                    string username = tokkens[1];
                    if (!followersLike.ContainsKey(username))
                    {
                        followersComment[username] = 0;
                        followersLike[username] = 0;
                    }
                    followersComment[username]++;
                }
                else if (command.Contains("Blocked"))
                {
                    string[] tokkens = command.Split();
                    string username = tokkens[1];
                    if (!followersLike.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                        continue;
                    }
                    followersComment.Remove(username);
                    followersLike.Remove(username);
                }
            }
            //output
            Console.WriteLine($"{followersComment.Count} followers");
            var followersSum = new Dictionary<string, int>();
            followersLike = followersLike.OrderByDescending(p => p.Value).ThenBy(p => p.Key).ToDictionary(x=>x.Key,k=>k.Value);
            foreach (var follower in followersLike)
            {
                followersSum[follower.Key] = follower.Value + followersComment[follower.Key];
            }
            foreach (var follower in followersSum)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
