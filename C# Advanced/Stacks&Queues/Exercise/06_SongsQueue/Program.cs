using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            var songs = new Queue<string>(input);
            while (true)
            {
                if (songs.Count == 0)
                {
                    break;
                }

                var command = Console.ReadLine();
                if (command.Contains("Add"))
                {
                    var song = command.Remove(0, 4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }
                    songs.Enqueue(song);
                }

                else if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }

                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
