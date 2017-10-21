using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] options = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> newNums = new List<int>();
            for (int i = 0; i < options[0]; i++)
            {
                newNums.Add(numbers[i]);
            }
            newNums.RemoveRange(0, options[1]);
            if (newNums.Contains(options[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
