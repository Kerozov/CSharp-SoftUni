using System;

namespace _09_kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = null ;
            int bestCount = 0;
            int bestSum = 0;
            int bestBeginIndex = 0;
            string bestSequance = "";
            int counter = 0;
            int bestCounter = 0;

            while ((input=Console.ReadLine())!="Clone them!")
            {
                
                string sequance = input.Replace("!", "");
                string[] dnaParts = sequance.Split("0", StringSplitOptions.RemoveEmptyEntries);


                int count = 0;
                int sum = 0;
                string bestSubSequence = "";
                counter++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length>count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }


                int beginIndex = sequance.IndexOf(bestSubSequence);



                if (count > bestCount
                    || (count == bestCount && beginIndex < bestBeginIndex)
                    || (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum)
                   || counter == 1)
                {
                    bestCount = count;
                    bestSequance = sequance;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
              

            }



            char[] ARRrES = bestSequance.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",ARRrES));

        }
    }
}
