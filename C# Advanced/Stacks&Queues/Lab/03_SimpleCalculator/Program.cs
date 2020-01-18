using System;

namespace _03_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var result = new Stack<string>(input);
            var secondInput = Console.ReadLine().Split();

            while (secondInput[0].ToLower() != "end")
            {
                string command = secondInput[0];
                string word = secondInput[1];
                if (command.ToLower() == "add")
                {
                    string number = secondInput[2];
                    result.Push(word);
                    result.Push(number);
                }
                else if (command.ToLower() == "remove")
                {
                    if (result.Count > int.Parse(word))
                    {
                        for (int i = 0; i < int.Parse(word); i++)
                        {
                            result.Pop();
                        }
                    }
                }
                secondInput = Console.ReadLine().Split();

            }
            int sum = 0;
            foreach (var number in result)
            {
                sum += int.Parse(number);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
