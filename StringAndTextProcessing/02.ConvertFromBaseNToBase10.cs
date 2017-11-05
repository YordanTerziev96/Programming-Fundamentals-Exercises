using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger decNumber = 0;
            int counter = 0;
            while (number > 0)
            {
               decNumber += (number % 10) * BigInteger.Pow(baseN, counter);
               number /= 10;
               counter++;
            }
            
            Console.WriteLine(decNumber);
        }
    }
}
