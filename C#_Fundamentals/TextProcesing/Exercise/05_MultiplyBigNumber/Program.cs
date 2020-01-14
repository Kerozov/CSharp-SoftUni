using System;
using System.Linq;
using System.Text;

namespace _05_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string longNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            var product = new StringBuilder();
            int rest = 0;
            foreach (var c in longNumber.Reverse())
            {
                int digits = int.Parse(c.ToString());
                int result = digits * number + rest;
                int n = result % 10;
                product.Insert(0, n);
                rest = result / 10;
            }
            if (rest > 0)
            {
                product.Insert(0, rest);
            }
            string res = product.ToString().TrimStart('0');
            if (res.Length == 0)
            {
                res = "0";
            }
            Console.WriteLine(res);
        }
    }
}
