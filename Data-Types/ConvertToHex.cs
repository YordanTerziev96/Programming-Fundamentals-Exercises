using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToHEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);

        }
    }
}
