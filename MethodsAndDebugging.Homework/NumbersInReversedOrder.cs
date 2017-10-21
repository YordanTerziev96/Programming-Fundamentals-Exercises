using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string n = Console.ReadLine();
            string reversed = Reverse(n);
            Console.WriteLine(reversed);

        }
        static string Reverse(string number)
        {
            char[] rev = number.ToCharArray();
            string reversed = "";
            for (int i = rev.Length - 1; i >= 0; i--)
            {
                reversed += rev[i];
            }
            
            return reversed;
        }
    }
}
