using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0] != "Odd" && command[0] != "Even")
            {
                int num = 0;
                
                if (command[0] == "Delete" )
                {
                    num = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == num);
                }
                if (command[0] == "Insert")
                {
                    num = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, num);
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (command[0] == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            if (command[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }

        }
    }
}
