using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            string[] phrases =  { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int index = rnd.Next(phrases.Length);
                int index2 = rnd.Next(events.Length);
                int index3 = rnd.Next(authors.Length);
                int index4 = rnd.Next(cities.Length);
                Console.WriteLine($"{phrases[index]} {events[index2]} {authors[index3]} - {cities[index4]}");
            }


        }
    }
}
