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
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", PrintPrime(n,m).ToArray());
            Console.WriteLine(numbers);
            
         
        }
        private static List<int> PrintPrime(int start, int end)
        {
            var result = new List<int>();
            
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) {
                    isPrime = false;

                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }

            }
            return result;
            
        }
    }
}