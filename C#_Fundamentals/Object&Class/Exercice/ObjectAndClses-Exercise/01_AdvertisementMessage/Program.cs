using System;

namespace _01_AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phraces = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.","I have succeeded with this product.", "Makes miracles. I'm happy about the results!", "I can't believe but now I feel awesome." , "Try it yourself, I am very satisfied. " };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas","Sofia","Plovdiv","Varna","Ruse" };
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
               int randomIndex= random.Next(0, phraces.Length);
                string randomPhrace = phraces[randomIndex];
                randomIndex= random.Next(0, events.Length);
                string randomEvent = events[randomIndex];
                string randomAuthor = authors[randomIndex];
                string randomCity = cities[randomIndex];
                Console.WriteLine($"{randomPhrace} {randomEvent} {randomAuthor} - {randomCity}.");
            }


        }
    }
}
