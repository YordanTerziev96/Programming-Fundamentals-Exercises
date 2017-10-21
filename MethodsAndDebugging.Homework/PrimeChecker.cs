using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if (n == 0 || n == 1) {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            bool isBool = true;
       
                for (long i = 3; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isBool = false;
                    }

                }
                return isBool;
        }
    }
}