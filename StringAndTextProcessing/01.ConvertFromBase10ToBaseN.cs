using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger decNumber = number;
            List<BigInteger> Nnumber = new List<BigInteger>();
            
            while (decNumber > 0)
            {
                BigInteger digit = decNumber % baseN;
                Nnumber.Add(digit);
                decNumber /= baseN;
            }
            Nnumber.Reverse();
            Console.WriteLine(string.Join("", Nnumber));
        }
    }
}
