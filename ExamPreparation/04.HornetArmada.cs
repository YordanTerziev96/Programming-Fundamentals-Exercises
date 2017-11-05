using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> legionSoldiers =
                new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionAvtivities = new Dictionary<string, long>();
            long n = long.Parse(Console.ReadLine());
            for (long i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(inputArgs[0]);
                string legion = inputArgs[1];
                string soldier = inputArgs[2];
                long count = long.Parse(inputArgs[3]);

                if (!legionAvtivities.ContainsKey(legion))
                {
                    legionSoldiers.Add(legion, new Dictionary<string, long>());
                    legionAvtivities.Add(legion, lastActivity);
                }
                if (lastActivity > legionAvtivities[legion])
                {
                    legionAvtivities[legion] = lastActivity;
                }
                if (!legionSoldiers[legion].ContainsKey(soldier))
                {
                    legionSoldiers[legion].Add(soldier, 0);
                }
                legionSoldiers[legion][soldier] += count;

            }
            var prlongArgs = Console.ReadLine().Split('\\');
            if (prlongArgs.Length > 1)
            {
                long activity = long.Parse(prlongArgs[0]);
                string soldierType = prlongArgs[1];

                foreach (var legionEntry in legionSoldiers.Where(legion => legion.Value.ContainsKey(soldierType)).OrderByDescending(legion => legion.Value[soldierType]))
                {
                    if(legionAvtivities[legionEntry.Key] < activity)
                    Console.WriteLine($"{legionEntry.Key} -> {legionEntry.Value[soldierType]}");
                }
            }
            else
            {
                string soldier = prlongArgs[0];
                foreach (var legionEntry in legionAvtivities.OrderByDescending(x => x.Value))
                {
                    if (legionSoldiers[legionEntry.Key].ContainsKey(soldier))
                    {
                        Console.WriteLine($"{legionEntry.Value} : {legionEntry.Key}");
                    }

                }
            }

        }
    }
}
