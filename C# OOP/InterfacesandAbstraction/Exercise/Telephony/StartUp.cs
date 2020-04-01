using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var secondLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var smartPhone = new Smartphone();
            var stationaryPhone = new StationaryPhone();
            bool flag = false;

            foreach (var number in firstLine)
            {
                flag = false;
                foreach (var digit in number)
                {
                    if (!char.IsDigit(digit))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                else if (number.Length == 10)
                {
                    Console.WriteLine(smartPhone.Call(number));
                }
                else
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }
            }

            foreach (var URL in secondLine)
            {
                flag = false;
                foreach (var digit in URL)
                {
                    if (char.IsDigit(digit))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                else
                {
                    Console.WriteLine(smartPhone.Browse(URL));
                }
            }
        }
    }
}
