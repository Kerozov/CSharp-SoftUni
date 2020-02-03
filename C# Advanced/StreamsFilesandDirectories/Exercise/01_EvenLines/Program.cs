using System;
using System.IO;
using System.Linq;

namespace _01_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new StreamReader(@".\text.txt");
            var count = 0;
            while (!stream.EndOfStream)
            {
                var currnet = stream.ReadLine();
                if (currnet == null)
                {
                    break;
                }
                if (count % 2 == 0)
                {
                    currnet = currnet.Replace('-', '@');
                    currnet = currnet.Replace(',', '@');
                    currnet = currnet.Replace(',', '@');
                    currnet = currnet.Replace('!', '@');
                    currnet = currnet.Replace('?', '@');
                    currnet = currnet.Replace('.', '@');
                    currnet = currnet.Replace(", ", "@");
                    currnet = string.Join(" ", currnet.Split(' ').Reverse());
                    Console.WriteLine(currnet);
                }
                count++;
            }
           
        }
    }
}

