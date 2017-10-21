using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, SortedDictionary<string, BigInteger>> country = new Dictionary<string, SortedDictionary<string, BigInteger>>();
            Dictionary<string, BigInteger> countryPopulation = new Dictionary<string, BigInteger>();
            while (input[0] != "report")
            {
                string city = input[0];
                string countryy = input[1];
                BigInteger population = BigInteger.Parse(input[2]);
                if (country.ContainsKey(countryy))
                {
                    country[countryy].Add(city, population);
                }
                else
                {
                    country.Add(countryy, new SortedDictionary<string, BigInteger>());
                    country[countryy].Add(city, population);
                }


                input = Console.ReadLine().Split('|').ToArray();
            }
            foreach (var item in country)
            {
                BigInteger sum = 0;
                foreach (var city in item.Value)
                {
                    sum += city.Value;
                }
                countryPopulation.Add(item.Key, sum);
            }
            foreach (var sum in countryPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} (total population: {1})", sum.Key, sum.Value);

                foreach (var cntry in country)
                {

                    foreach (var item in cntry.Value.OrderByDescending(x => x.Value))
                    {
                        if (sum.Key == cntry.Key)
                        {
                            Console.WriteLine("=>{0}: {1}", item.Key, item.Value);
                        }
                        
                    }
                }

            }
        }
    }
}

