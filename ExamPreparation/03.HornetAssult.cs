using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssult
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();
            List<long> aliveBeehieves = new List<long>();
            foreach (var beehieve in beehives)
            {
                if (hornets.Count == 0)
                {
                    aliveBeehieves.Add(beehieve);
                    continue;
                }
                var power = hornets.Sum();
                if (power >= beehieve)
                {
                    if (power == beehieve)
                    {
                        hornets.RemoveAt(0);
                    }
                    
                }
                else
                {
                    aliveBeehieves.Add(beehieve - power);
                    hornets.RemoveAt(0);
                }
            }
            if (aliveBeehieves.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehieves));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
