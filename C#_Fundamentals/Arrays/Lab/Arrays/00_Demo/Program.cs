using System;
using System.Linq;
namespace _00_Demo
{
    class Program
    {
        static void Main(string[] args) {

            //string[] names = new string[10];

            //names[1] = "ivan";

            //var numbers = new int[50];//0-49 kletki
            //numbers[4] = 3;
            //Console.WriteLine(numbers[0]+""+numbers[4]);






            //int[] numbers = new int[10];
            //for (int i = 1; i <= numbers.Length; i++)
            //{
            //    numbers[i] = i;
            //    Console.WriteLine(numbers[i]);
            //}




            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers);
            //}





            //string[] day =
            // {
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "nz",
            //    "Friday",
            //    "Saturday",
            //    "Sunday",
            //};
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(day[number-1]);




            //int number = int.Parse(Console.ReadLine());
            //int[] numbers = new int[number];
            //for (int i = 0; i < number; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine()); 
            //}
            //Console.WriteLine(numbers[0]);




            //string text = Console.ReadLine();
            //string[] names = text.Split();


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //int[] numbers = new int[5];
            //numbers[1] = 1;
            //numbers[2] = 2;
            //numbers[0] = 0;




            //int[] otherNumbers = new int[5];

            //for (int i = 0; i < otherNumbers.Length; i++)
            //{
            //    otherNumbers[i] = numbers[i];
            //}
            //for (int i = 0; i < otherNumbers.Length; i++)
            //{
            //    Console.WriteLine(otherNumbers[i]);
            //}




            //string text = Console.ReadLine();
            //string[] names = text.Split();


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}

            // //int da
            //y = int.Parse(Console.ReadLine());

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //if (day>=1&&day<=7)
            //{
            //Console.WriteLine(days[day - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}

            //string[] nums = Console.ReadLine().Split();
            //int[] numbers = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    numbers[i] =  int.Parse(nums[i]);
            //    Console.WriteLine(numbers[i]);
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = n-1; i >= 0; i--)
            //{

            //    Console.Write(numbers[i]+" ");
            //}


            //double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    double number = nums[i];
            //    double roundNumber = Math.Round(number, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{ nums[i]} => {roundNumber}");
            //}

            //string numbersOnLIne = Console.ReadLine();

            //string[] numbers = numbersOnLIne.Split();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //string[] text =Console.ReadLine().Split();
            //for (int i = text.Length-1; i >= 0; i--)
            //{
            //    Console.Write(text[i]+" ");
            //}
            //string[] text = Console.ReadLine().Split();
            //int[] number = new int[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    number[i] = int.Parse(text[i]);
            //}

            //string[] texts = Console.ReadLine().Split();

            //for (int i = 0; i < texts.Length; i++)
            //{
            //    Console.WriteLine(texts[texts.Length-i-1]);


            ////}
            ///

















            //int[] n = Console.ReadLine()
            //          .Split()
            //          .Select(int.Parse)
            //          .ToArray();
            //int sum = 0;
            //int sumEven = 0;
            //int sumOdd = 0;


            //for (int i = 0; i<n.Length; i++)
            //{

            //    if (n[i] % 2 == 0)
            //    {
            //        sumEven += n[i];
            //    }
            //}
            //for (int i = 0; i < n.Length; i++)
            //{

            //    if (n[i] % 2 == 1)
            //    {
            //        sumOdd += n[i];
            //    }
            //}
            //Console.WriteLine(sumEven-sumOdd);





            //int[] numbers = Console.ReadLine()
            //                  .Split()
            //                  .Select(int.Parse)
            //                  .ToArray();
            //int sumOdd = 0;
            //int sumEven = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        sumOdd += numbers[i];
            //    }
            //}
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i]% 2== 1)
            //    {
            //        sumEven+= numbers[i];
            //    }
            //}
            //Console.WriteLine(sumOdd- sumEven);


            //int[] numbers1 = Console.ReadLine()
            //                 .Split()
            //                 .Select(int.Parse)
            //                 .ToArray();

            //int[] numbers2 = Console.ReadLine()
            //                 .Split()
            //                 .Select(int.Parse)
            //                 .ToArray();


            //int sum1 = 0;
            //int sum2 = 0;
            //int difference = 0;
            //bool istrue = true;
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    sum1 += numbers1[i];
            //}
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    sum2 += numbers2[i];
            //}
            //for (int i = 0; i < numbers2.Length ; i++)
            //{
            //    if (numbers1[i]!=numbers2[i])
            //    {
            //        difference =i;
            //        istrue = false;
            //        break;

            //    }
            //}

            //if (sum1==sum2&&istrue)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Arrays are not identical. Found difference at {difference} index");
            //}

            //int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] condensed = new int[number.Length-1];
            //int sum2 = 0;
            //for (int i = 0; i < number[0]; i++)
            //{
            //    condensed[i] = number[i] + number[i + 1];
            //    number[i] = condensed[i];
            //    sum2 = number[i];
            //}
            //Console.WriteLine(condensed);
        }
        }
    }
