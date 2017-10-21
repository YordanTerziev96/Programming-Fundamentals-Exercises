using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondsPerPictures = long.Parse(Console.ReadLine());
            long filterPercent = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());

            long filterSeconds = pictures * secondsPerPictures;
            double filteredPics = (long)Math.Ceiling(filterPercent * pictures / 100.0);
            double uploadSeconds = (filteredPics * uploadTimePerPicture);
            long totalSeconds = filterSeconds + (long)uploadSeconds;
           

            
            

            TimeSpan span = TimeSpan.FromSeconds(totalSeconds);
            string result = span.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);

        }
    }
}
