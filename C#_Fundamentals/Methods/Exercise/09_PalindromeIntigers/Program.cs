using System;

namespace _09_PalindromeIntigers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number=null;
            while ((number=  Console.ReadLine()) != "END")
            {
                Console.WriteLine(isPalindrome( number).ToString().ToLower());
            }
        }
        static bool isPalindrome(string number)
        {
            bool isPalindrome = true;
            for (int i = 0; i<number.Length/2; i++)
            {

                int number2 = number.Length - i - 1;
                    if(number[i] != number[number2])
                    {
                        isPalindrome = false;
                    break;
                     
                    }
                
            }
            return isPalindrome;
        }
    }
}
