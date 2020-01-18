using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =Console.ReadLine();
            var index = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (symbol=='(')
                {
                    index.Push(i);
                }
                else if (symbol==')')
                {
                    var curentIndex = index.Pop();
                    var text = input.Substring(curentIndex,i-curentIndex ) + ")";
                    Console.WriteLine(text) ;
                }
            }

        }
    }
}
