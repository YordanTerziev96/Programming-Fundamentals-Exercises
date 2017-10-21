using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();
           // numbers.Reverse();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int temp = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = numbers[i];
                numbers[i] = temp;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }

            if (positiveNumbers.Count > 0)
            {
                Console.WriteLine(String.Join(" ", positiveNumbers));
            }
            else
            {
              Console.WriteLine("empty");
            }

        }
    }
}
