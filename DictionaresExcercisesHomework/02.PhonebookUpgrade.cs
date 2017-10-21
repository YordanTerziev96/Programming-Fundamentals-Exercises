using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] info = command.Split(' ').ToArray();
                if (info[0] == "A")
                {
                    phonebook[info[1]] = info[2];
                }
                if (info[0] == "S")
                {
                    bool isTrue = phonebook.ContainsKey(info[1]);
                    foreach (var item in phonebook.Where(x => x.Key == info[1]))
                    {
                        if (isTrue)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                        }
                    }
                    if (!isTrue)
                    {
                        Console.WriteLine($"Contact {info[1]} does not exist.");
                    }

                }
                if (command == "ListAll")
                {
                    foreach (var name in phonebook.Keys.OrderBy(x => x))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
