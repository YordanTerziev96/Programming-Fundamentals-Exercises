using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var userIP = new SortedDictionary<string, Dictionary<string, int>>();



            while (input[0] != "end")
            {

                var ip = input[0].Split('=').ToArray();

                var userName = input[2].Split('=').ToArray();
                int counter = 1;
                if (!userIP.ContainsKey(userName[1]))
                {
                    userIP.Add(userName[1], new Dictionary<string, int>());
                }
                if (!userIP[userName[1]].ContainsKey(ip[1]))
                {
                    userIP[userName[1]].Add(ip[1], counter);
                }
                else
                {
                    userIP[userName[1]][ip[1]]++;
                }
                input = Console.ReadLine().Split(' ').ToArray();

            }
            foreach (var user in userIP)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{ log.Key} => { log.Value}.");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}
