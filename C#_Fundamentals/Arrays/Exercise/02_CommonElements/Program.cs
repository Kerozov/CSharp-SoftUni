using System;
using System.Linq;
namespace _02_CommonElements
{
    class Program
    {
        private static object SplitOptions;

        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Split();
            string[] text2 = Console.ReadLine().Split();
            
            for (int i = 0; i < text2.Length; i++)
            {
                for (int k = 0; k < text1.Length; k++)
                {
                if (text1[k]==text2[i])
                {
                        Console.Write(text2[i] + " ");
                    }

                }
            }
            
            
        }
    }

}
