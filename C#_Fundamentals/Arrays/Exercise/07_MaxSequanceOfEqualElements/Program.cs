using System;
using System.Linq;

namespace _07_MaxSequanceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int maxValue = 0;
            int maxNum = 0;
            int[] maxs = new int[numbers.Length ];
            for (int i = 0; i < numbers.Length-1; i++)
            {
               
                    if (numbers[i+1]==numbers[i])
                    {
                        counter += 1;
                        if (counter>maxValue)
                        {
                            maxValue = counter;
                            maxNum = numbers[i];
                        }
                    }
                    else
                    {

                        counter = 1;
                        
                    }

                
            }
            if (counter==1&&maxNum==0)
            {
                Console.WriteLine(numbers[0]); 
            }
            else
            {
            int[] newArr = new int[maxValue];
            for (int i = 0; i < maxValue; i++)
            {
                newArr[i] = maxNum;
            }
            foreach (var item in newArr)
            {
                Console.Write(item+" ");
            }
            }


               
        }
    }
}
