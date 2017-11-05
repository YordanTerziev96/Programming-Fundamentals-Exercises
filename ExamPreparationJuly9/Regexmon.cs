using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            String bojoPattern = @"[a-zA-Z]+-[a-zA-Z]+";
            String didiPattern = @"[^a-zA-Z\-]+";

            Regex didiRegex = new Regex(didiPattern);
            Regex bojoRegex = new Regex(bojoPattern);

            while (true)
            {
                Match didiMatch = didiRegex.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstDidiIndex = didiMatch.Index;
                input = input.Substring(firstDidiIndex + didiMatch.Length);
                
                Match bojoMatch = bojoRegex.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstBojoIndex = bojoMatch.Index;
                input = input.Substring(firstBojoIndex + bojoMatch.Length);
            }

        }
    }
}
