using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (command[0])
                {
                    case "exchange":
                        ExchangeArray(numbers, command[1]);
                        break;
                    case "max":
                        MaxEvenOrOdd(numbers, command[1]);
                        break;
                    case "min":
                        MinEvenOrOdd(numbers, command[1]);
                        break;
                    case "first":
                        FirstLastEvenOrOdd(numbers, command[1], command[2], command[0]);
                        break;
                    case "last":
                        FirstLastEvenOrOdd(numbers, command[1], command[2], command[0]);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void FirstLastEvenOrOdd(List<int> numbers, string str, string type, string str2)
        {
            int count = int.Parse(str);
            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums.Add(numbers[i]);
                }
                else
                {
                    oddNums.Add(numbers[i]);
                }
            }
            if (str2 == "first")
            {
                if (count <= numbers.Count)
                {
                    if (type == "even")
                    {
                        if (count > evenNums.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNums)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNums.Take(count))}]");
                        }
                    }
                    if (type == "odd")
                    {
                        if (count > oddNums.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", oddNums)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", oddNums.Take(count))}]");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
            else
            {
                
                
                if (count <= numbers.Count)
                {
                    if (type == "even")
                    {
                        if (count > evenNums.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", evenNums)}]");
                        }
                        else
                        {
                            evenNums.Reverse();
                            List<int> lastEven = new List<int>();

                            for (int i = 0; i < count; i++)
                            {
                                lastEven.Add(evenNums[i]);
                            }
                            lastEven.Reverse();
                            Console.WriteLine($"[{string.Join(", ", lastEven)}]");
                        }
                    }
                    if (type == "odd")
                    {
                        if (count > oddNums.Count)
                        {
                            Console.WriteLine($"[{string.Join(", ", oddNums)}]");
                        }
                        else
                        {
                            oddNums.Reverse();
                            List<int> lastOdd = new List<int>();
                            
                            for (int i = 0; i < count; i++)
                            {
                                lastOdd.Add(oddNums[i]);
                            }
                            lastOdd.Reverse();
                            Console.WriteLine($"[{string.Join(", ", lastOdd)}]");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
           
            }
        }

        private static void MinEvenOrOdd(List<int> numbers, string type)
        {
            int minEven = int.MaxValue;
            int minOdd = int.MaxValue;

            int minEvenIndex = -1;
            int minOddIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minEven)
                    {
                        minEven = numbers[i];
                        minEvenIndex = i;
                    }
                }
                else
                {
                    if (numbers[i] <= minOdd)
                    {
                        minOdd = numbers[i];
                        minOddIndex = i;
                    }
                }
            }
            if (type == "even")
            {
                if (minEvenIndex != -1)
                {
                    Console.WriteLine(minEvenIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (minOddIndex != -1)
                {
                    Console.WriteLine(minOddIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void MaxEvenOrOdd(List<int> numbers, string type)
        {
            int maxEven = 0;
            int maxOdd = 0;

            int maxEvenIndex = -1;
            int maxOddIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxEven)
                    {
                        maxEven = numbers[i];
                        maxEvenIndex = i;
                    }
                }
                else
                {
                    if (numbers[i] >= maxOdd)
                    {
                        maxOdd = numbers[i];
                        maxOddIndex = i;
                    }
                }
            }
            if (type == "even")
            {
                if (maxEvenIndex != -1)
                {
                    Console.WriteLine(maxEvenIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (maxOddIndex != -1)
                {
                    Console.WriteLine(maxOddIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void ExchangeArray(List<int> nums, string str)
        {
            int index = int.Parse(str);
            
            List<int> newList = new List<int>();
            int count = nums.Count - index - 1;
            int endIndex = nums.Count - 1;
            if (index < 0 || index >= nums.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else if (!(index == endIndex))
            {
                for (long i = 0; i < count; i++)
                {
                    newList.Add(nums[endIndex]);
                    nums.RemoveAt(endIndex);
                    endIndex--;
                }
                newList.Reverse();
                nums.InsertRange(0, newList);
            }
            
        }
    }
}
