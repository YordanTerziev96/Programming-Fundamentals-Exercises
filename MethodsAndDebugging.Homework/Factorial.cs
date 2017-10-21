using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger fac = Factorial(number);
        Console.WriteLine(fac);
    }
    static BigInteger Factorial(BigInteger n)
    {
        BigInteger fac = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            fac *= i;
        }
        return fac;
    }
}
