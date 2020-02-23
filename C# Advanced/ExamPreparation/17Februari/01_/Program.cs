using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSockInput = Console.ReadLine()
                 .Split()
                 .Select(int.Parse);
            var rightSockInput = Console.ReadLine()
                 .Split()
                 .Select(int.Parse);
            var colection = new List<int>();
            var leftSocks = new Stack<int>(leftSockInput);
            var rightSocks = new Queue<int>(rightSockInput);
            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                var leftSock = leftSocks.Peek();
                var rightSock = rightSocks.Peek();
                if (leftSock>rightSock)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    var sum = leftSock + rightSock;
                    colection.Add(sum);
                }
                else if (leftSock < rightSock)
                {
                    leftSocks.Pop();
                }
                else
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    leftSocks.Push(leftSock + 1);
                }
            }
            var stringColection = string.Join(" ", colection);
            Console.WriteLine(colection.OrderByDescending(x=>x).First());
            Console.WriteLine(stringColection);
        }
    }
}
