using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            decimal exhaustfactor = N * 0.5m;
            int count = 0;
            while (true)
            {
                if (N < M)
                {
                    break;
                }
                N -= M;
                count++;
                if (N == exhaustfactor && Y > 0)
                {
                    N /= Y;
                }
                
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
