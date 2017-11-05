using System;/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d+([a-zA-Z]+)[^a-zA-Z]*$";
            Regex regex = new Regex(pattern);
            string message;
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (input == "Over!")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                if (regex.IsMatch(input))
                {
                    message = regex.Match(input).Groups[1].ToString();
                    if (n == message.Length)
                    {
                        StringBuilder sb = new StringBuilder();
                        MatchCollection digits = Regex.Matches(input, @"\d");
                        foreach (Match m in digits)
                        {
                            int index = int.Parse(m.Value);-----------------------------------
                                ++++
                            if (index > message.Length - 1)
                            {
                                sb.Append(" ");
                            }
                            else
                            {
                                sb.Append(message[index]);
                            }
                        }
                        Console.WriteLine($"{message} == {sb}");
                    }
                }
            }
        }   
    }
}
+\

/+