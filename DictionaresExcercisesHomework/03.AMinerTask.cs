using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();
           
            for (int i = 0; ; i++)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (!miner.ContainsKey(name))
                {
                    miner.Add(name, 0);
                }
                miner[name] += quantity;
            }
            
            foreach (var item in miner)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        
           

            

        }
    }
}
