using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> handOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> handTwo = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            
           while(handOne.Count>0&&handTwo.Count>0)
            {
                
                    if (handOne[0] > handTwo[0])
                    {
                        handOne.Add(handOne[0]);
                        handOne.Add(handTwo[0]);
                    }
                    else if(handOne[0] < handTwo[0])
                    {
                        handTwo.Add(handTwo[0]);  
                        handTwo.Add(handOne[0]);
                    }
                   
                
                handOne.RemoveAt(0);
                handTwo.RemoveAt(0);
               
            }
            
            if (handOne.Count > handTwo.Count)
            {
                int sum = handOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = handTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
