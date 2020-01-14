using System;

namespace _02_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            
            Console.WriteLine(Sum(text[0],text[1]));
        }
        static int Sum(string textOne,string textTwo)
        {
            int sum = 0;
            int minLength = Math.Min(textOne.Length,textTwo.Length);
            string maxlength =textOne;
            if (maxlength.Length<textTwo.Length)
            {
                maxlength = textTwo;
            }
            for (int i = 0; i < minLength; i++)
            {
                sum += textOne[i] * textTwo[i];
            }
            for (int i = minLength; i < maxlength.Length; i++)
            {
                sum += maxlength[i];
            }
            return sum;
        }
    }
}
