using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int max = GetMax(num1, num2);
            if (max > num3) {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine(num3);
            }


        }
        static int GetMax(int a, int b) {
            if (a > b)
            {
                return a;
            }
            else {
                return b;
            }
        }
    }
}
