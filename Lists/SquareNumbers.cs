using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((Math.Sqrt(numbers[i])) % 1 == 0)
                {
                    squareNums.Add(numbers[i]);
                }
            }
            squareNums.Sort();
            squareNums.Reverse();
            Console.WriteLine(String.Join(" ", squareNums));
        }
    }
}
