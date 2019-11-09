using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split('_')
                    .ToArray();
                var song = new Song();
                song.name = text[1];
                song.typeList = text[0];
               
                songs.Add(song);
            }
            string type = Console.ReadLine();
            if (type=="all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.typeList);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.typeList=="type")
                    {
                        Console.WriteLine(item.typeList);
                    }
                }
            }

        }

       
    }
}


    class Song
    {
        public string typeList { get; set; }
        public string name { get; set; }
        public int time { get; set; }
    }


