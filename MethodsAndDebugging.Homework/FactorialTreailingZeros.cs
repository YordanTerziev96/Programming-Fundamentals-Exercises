using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger fac = Factorial(number);
        int zeros = ZeroCounter(fac);
        Console.WriteLine(zeros);
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
    static int ZeroCounter(BigInteger n)
    {
        int counter = 0;
        while (n % 10 == 0 && n > 0)
        {
            counter++;
            n /= 10;
        }
        return counter;

    }
}
