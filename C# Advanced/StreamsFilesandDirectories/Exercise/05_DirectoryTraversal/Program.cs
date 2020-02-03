using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

namespace _05_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var directory = Directory.GetFiles(input);
            var dict = new Dictionary<string, Dictionary<string, double>>();
            foreach (var dirPath in directory)
            {
                string name = dirPath.Split('\\').Last();
                string ext = name.Split('.').Last();
                if (!dict.ContainsKey(ext))
                {
                    dict[ext] =new Dictionary<string, double>();
                }
                var info = new FileInfo(name);
                dict[ext][name] = info.Length;
            }

            foreach (var ext in dict)
            {
                Console.WriteLine("."+ext.Key );
                foreach (var name in ext.Value)
                {
                    Console.WriteLine($"--{name.Key} - {name.Value}kb");
                }
            }
        }
    }
}
