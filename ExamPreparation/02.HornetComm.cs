using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string messagePattern = "^([\\d]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastPattern = "^([\\D]+) <-> ([0-9a-zA-Z]+)$";
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                
                if (messageRegex.IsMatch(input))
                {
                    Match match = messageRegex.Match(input);
                    string recipientCode = string.Join("", match.Groups[1].Value.Reverse());
                    string message = match.Groups[2].Value;
                    string allString = recipientCode + " -> " + message;
                    messages.Add(allString);

                }
                if (broadcastRegex.IsMatch(input))
                {
                    Match match = broadcastRegex.Match(input);
                    string message = match.Groups[1].Value;
                    string frequency = DecryptFrequency(match.Groups[2].Value);
                    string allString = frequency + " -> " + message;
                    broadcasts.Add(allString);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts: ");
            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
            
        }

        private static string DecryptFrequency(string value)
        {
            string decrypted = "";
            foreach (char curr in value)
            {
                if (curr >= 65 && curr <= 90)
                {
                    decrypted += (char)(curr + 32);
                }
                else if (curr >= 97 && curr <= 122)
                {
                    decrypted += (char)(curr - 32);
                }
                else
                {
                    decrypted += curr;
                }
            }
            return decrypted;
        }
    }
}
