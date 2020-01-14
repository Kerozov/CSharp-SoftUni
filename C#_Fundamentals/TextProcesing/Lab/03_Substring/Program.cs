using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();  
            
            while (word.Contains(key))
            {
                int index = word.IndexOf(key);
                word = word.Remove(index, key.Length);
            }
            Console.WriteLine(word);
        }
    }
}
