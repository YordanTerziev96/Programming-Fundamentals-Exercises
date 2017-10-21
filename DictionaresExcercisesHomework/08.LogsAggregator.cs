using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            SortedDictionary<string, SortedDictionary<string, int>> users = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string userName = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);
                if (!users.ContainsKey(userName))
                {
                    users.Add(userName, new SortedDictionary<string, int>());
                }
                if (!users[userName].ContainsKey(ip))
                {
                    users[userName][ip] = 0;
                }
                users[userName][ip] += duration;
                

            }
            foreach (var name  in users)
            {
                var sum = name.Value.Values.Sum();
                Console.Write("{0}: {1} ", name.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", name.Value.Keys));
                Console.WriteLine("]");
               
            }
        }
    }
}
