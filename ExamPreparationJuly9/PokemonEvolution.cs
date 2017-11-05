using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> inputMap = new Dictionary<string, List<string>>();
            string input;
            while ("" != (input = Console.ReadLine()))
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 1)
                {
                    if (!inputMap.ContainsKey(tokens[0]))
                    {
                        inputMap.Add(tokens[0], new List<string>());

                    }
                    string str = tokens[1] + " <-> " + tokens[2];
                    inputMap[tokens[0]].Add(str);
                }
                else if (inputMap.ContainsKey(tokens[0]))
                {
                    Console.WriteLine($"# {tokens[0]}");
                    inputMap[tokens[0]].ForEach(Console.WriteLine);
                }
            }
            foreach (var keyvaluePair in inputMap)
            {
                Console.WriteLine($"# {keyvaluePair.Key}");
                var ordered = keyvaluePair.Value.OrderByDescending((a) => { return int.Parse(a.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1]); });
                foreach (var output in ordered)
                {
                    Console.WriteLine(output);
                }

            }
        }
    }
}
