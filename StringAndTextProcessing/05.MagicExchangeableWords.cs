using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string str1 = input[0];
            string str2 = input[1];
            bool result = AreEqual(str1, str2);
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool AreEqual(string str1, string str2)
        {
            bool areEqual = false;
            char[] a = str1.Distinct().ToArray();
            char[] b = str2.Distinct().ToArray();
            if (a.Length == b.Length)
            {
                areEqual = true;
            }
            return areEqual;
            
        }
    }
}
