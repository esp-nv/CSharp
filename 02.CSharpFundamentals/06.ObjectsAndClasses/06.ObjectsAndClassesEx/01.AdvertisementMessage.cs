using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        private static readonly string[] Phrases = new string[]
        {
            "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can’t live without this product."
        };
      
        private static readonly string[] Events = new string[]
        {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
        };
      
        private static readonly string[] Authors = new string[]
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };
      
        private static readonly string[] Cities = new string[]
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
          
            Random random = new Random();
          
            List<string> advertisementMessages = new List<string>();
          
            for (int i = 0; i < n; i++)
            {
                string phrase = Phrases[random.Next(Phrases.Length)];
                string eventMessage = Events[random.Next(Events.Length)];
                string author = Authors[random.Next(Authors.Length)];
                string city = Cities[random.Next(Cities.Length)];
                advertisementMessages.Add($"{phrase} {eventMessage} {author} – {city}.");
            }

            foreach (string message in advertisementMessages.OrderBy(x => random.Next()))
            {
                Console.WriteLine(message);
            }
        }
    }
}
