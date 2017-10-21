using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dragonInfo =
                new Dictionary<string, Dictionary<string, List<string>>>();
            List<double> average = new List<double>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string dragonType = inputData[0];
                string dragonName = inputData[1];
                List<string> dragonArgs = new List<string>();
                AddValuesToList(inputData, dragonArgs);

                if (!dragonInfo.ContainsKey(dragonType))
                {
                    dragonInfo.Add(dragonType, new Dictionary<string, List<string>>());
                }
                if (!dragonInfo[dragonType].ContainsKey(dragonName))
                {
                    dragonInfo[dragonType][dragonName] = dragonArgs;
                }
                dragonInfo[dragonType][dragonName] = dragonArgs;

                
            }
            foreach (var type in dragonInfo)
            {
                average = Average(type.Value);
                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", type.Key, average[0], average[1], average[2]);
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    List<string> currStats = new List<string>();
                    currStats = dragon.Value;
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Key, currStats[0], currStats[1], currStats[2]);                    
                }

            }
        }

        private static List<double> Average(Dictionary<string, List<string>> dragonInfo)
        {
            double avDamage = 0;
            double avHealth = 0;
            double avArmor = 0;
            int count = 0;
            List<string> list = new List<string>();
            List<double> AverageList = new List<double>();
            foreach (var dragon in dragonInfo)
            {
                list = dragon.Value;
                avDamage += int.Parse(list[0]);
                avHealth += int.Parse(list[1]);
                avArmor += int.Parse(list[2]);
                count++;
                
            }
            avDamage = avDamage / count;
            avHealth = avHealth / count;
            avArmor = avArmor / count;
            AverageList.Add(avDamage);
            AverageList.Add(avHealth);
            AverageList.Add(avArmor);
            return AverageList;
        }

        private static void AddValuesToList(string[] inputData, List<string> list)
        {
            string health = inputData[3];
            string armor = inputData[4];
            string damage = inputData[2];

            if (inputData[2].Equals("null"))
            {
                damage = "45";
            }
            if (inputData[3].Equals("null"))
            {
                health = "250";
            }
            if (inputData[4].Equals("null"))
            {
                armor = "10";
            }
            list.Add(damage);
            list.Add(health);
            list.Add(armor);
        }
    }
}
