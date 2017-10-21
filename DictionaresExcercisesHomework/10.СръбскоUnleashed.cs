using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Dictionary<string, Dictionary<string, long>> info = new Dictionary<string, Dictionary<string, long>>();
            
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "End")
                {
                    break;
                }
                string[] input = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] checkData = text.Split(new char[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Length == checkData.Length)
                {
                    int indexSign = 0;
                    indexSign = DefineIndexPosition(input, indexSign);
                    string singerName = DefineSingerName(input, indexSign);
                    string vanue = DefineVanue(checkData, indexSign);
                    
                    int tickedPrice;
                    int tickedCount;
                    try
                    {
                        tickedPrice = int.Parse(input[input.Length - 2]);
                        tickedCount = int.Parse(input[input.Length - 1]);
                    }
                    catch
                    {
                        continue;
                    }
                    long currAmountOfMoney = (long)tickedPrice * tickedCount;
                    if (!info.ContainsKey(vanue))
                    {
                        info.Add(vanue, new Dictionary<string, long>());
                    }
                    if (!info[vanue].ContainsKey(singerName))
                    {
                        info[vanue][singerName] = 0;
                    }
                    info[vanue][singerName] += currAmountOfMoney;
                } 
                
              
                
            }
            foreach (var venue in info)
            {
                Console.WriteLine("{0}", venue.Key);
                foreach (var person in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", person.Key, person.Value);
                }
            }
        }
        private static string DefineVanue(string[] checkData, int index)
        {
            string[] vanues = new string[checkData.Length - index];
            for (int i = index - 1; i < checkData.Length - 2; i++)
            {
                vanues[i - index + 1] = checkData[i];
            }
            string vanue = string.Join(" ", vanues);
            
            return vanue;
        }
        private static string DefineSingerName(string[] inputData, int index)
        {
            string[] nameData = new string[index - 1];
            string name = "";
            for (int i = 0; i < index - 1; i++)
            {
                nameData[i] = inputData[i];
            }
            name = string.Join(" ", nameData);
            return name;
        }
        private static int DefineIndexPosition(string[] inputData, int index)
        {
            foreach (var a in inputData)
            {
                index++;
                if (a.Contains('@'))
                {
                    break;
                }
            }
            return index;
        }
    }
}
