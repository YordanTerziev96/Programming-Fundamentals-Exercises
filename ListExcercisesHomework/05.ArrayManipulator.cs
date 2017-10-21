using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab1RemoveNegatxvesAndReverse
{
    class Program
    {
        public static List<int> nums = new List<int>();
        static void Main(string[] args)
        {
            nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        nums.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "addMany":
                        int pos = int.Parse(command[1]);
                        for (int i = 2; i < command.Length; i++)
                        {
                            nums.Insert(pos, int.Parse(command[i]));
                            pos++;
                        }
                        break;
                    case "contains":
                        int index = nums.IndexOf(int.Parse(command[1]));
                        Console.WriteLine(index);
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        int positionsToMove = int.Parse(command[1]);
                        for (int j = 0; j < positionsToMove; j++)
                        {
                            int firstElement = nums[0];
                            for (int i = 1; i < nums.Count; i++)
                            {
                                nums[i - 1] = nums[i];
                            }
                            nums[nums.Count - 1] = firstElement;
                        }
                        break;
                    case "sumPairs":
                        for (int i = 0; i < nums.Count - 1; i += 2)
                        {
                            nums[i] += nums[i + 1];
                            nums[i + 1] = -1;
                        }
                        nums.RemoveAll(x => x == -1);
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Please write add, addMany, contains, shift or sumPairs");
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();

            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }
    }
}