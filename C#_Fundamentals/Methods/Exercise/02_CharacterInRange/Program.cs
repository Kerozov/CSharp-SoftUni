using System;

namespace _02_CharacterInRange
{
    class Program
    {

        
        static void Main(string[] args)
        {
            char firstRange = char.Parse(Console.ReadLine());
            char secondRange = char.Parse(Console.ReadLine());
            if (firstRange<secondRange )
            {
                for (int i = firstRange+1 ; i  <= secondRange-1; i++)
                {
                    Console.Write((char)i+" ");
                }
            }
            else
            {
                for (int i = secondRange+1; i <= firstRange-1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
