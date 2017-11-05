using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var c in input)
            {
                Console.Write("\\u");
                Console.Write("{0:x4}", (int)c);
            }
            Console.WriteLine();
        }
    }
}
