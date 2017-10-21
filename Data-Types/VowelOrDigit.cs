using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string smth = Console.ReadLine();
            int b;
            if (smth == "a" || smth == "e" || smth == "o" || smth == "i" || smth == "u" || smth == "y")
            {
                Console.WriteLine("vowel");
            }
            else if (int.TryParse(smth, out b)) {
                Console.WriteLine("digit");
            }

            else {
                Console.WriteLine("other");
            }

        }
    }
}
