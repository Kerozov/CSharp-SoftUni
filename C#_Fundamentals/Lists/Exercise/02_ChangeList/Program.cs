using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    class Program
    {
     

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string line = Console.ReadLine();             
            while (line!="end")
            {
                string[] com = line.Split(" ");
                string command = com[0];
                int value =int.Parse(com[1]);
               
                if (command=="Delete")
                {
                        numbers.RemoveAll(el => el == value);
                }
                else
                {
                    int index = int.Parse(com[2]);
                    numbers.Insert(index,value);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
       
    }
}
