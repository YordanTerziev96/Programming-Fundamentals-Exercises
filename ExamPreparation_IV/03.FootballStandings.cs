using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            string open = "{";
            string close = "}";
            string teamPattern = $@"[{delimiter}]{open}{delimiter.Length}{close}([a-zA-Z]+)[{delimiter}]{open}{delimiter.Length}{close}";
            Dictionary<string, int> teamsWithScore = new Dictionary<string, int>();
            Dictionary<string, int> teamsWithGoals = new Dictionary<string, int>();
            Regex teamRegex = new Regex(teamPattern);
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "final")
                {
                    break;
                }
                string[] inputInfo = input.Split(' ').ToArray();

                int[] result = inputInfo[2].Split(':').Select(int.Parse).ToArray();
                Match teamMatch1 = teamRegex.Match(inputInfo[0]);
                Match teamMatch2 = teamRegex.Match(inputInfo[1]);
            string firstTeam = teamMatch1.Groups[1].ToString().ToUpper();
            string secondTeam = teamMatch2.Groups[1].ToString().ToUpper();
            firstTeam = Reverse(firstTeam);
            secondTeam = Reverse(secondTeam);
                if (result[0] > result[1])
                {
                    
                    if (!teamsWithScore.ContainsKey(firstTeam))
                    {
                        teamsWithScore.Add(firstTeam, 0);
                    }
                    teamsWithScore[firstTeam] += 3;
                    if (!teamsWithScore.ContainsKey(secondTeam))
                    {
                        teamsWithScore.Add(secondTeam, 0);
                    }
                    teamsWithScore[secondTeam] += 0;
                }
                else if (result[0] < result[1])
                {
                    if (!teamsWithScore.ContainsKey(firstTeam))
                    {
                        teamsWithScore.Add(firstTeam, 0);
                    }
                    teamsWithScore[firstTeam] += 0;
                    if (!teamsWithScore.ContainsKey(secondTeam))
                    {
                        teamsWithScore.Add(secondTeam, 0);
                    }
                    teamsWithScore[secondTeam] += 3;
                }
                else
                {
                    if (!teamsWithScore.ContainsKey(firstTeam))
                    {
                        teamsWithScore.Add(firstTeam, 0);
                    }
                    teamsWithScore[firstTeam] += 1;
                    if (!teamsWithScore.ContainsKey(secondTeam))
                    {
                        teamsWithScore.Add(secondTeam, 0);
                    }
                    teamsWithScore[secondTeam] += 1;
                }
                if (!teamsWithGoals.ContainsKey(firstTeam))
                {
                    teamsWithGoals.Add(firstTeam, 0);
                }
                teamsWithGoals[firstTeam] += result[0];
                if (!teamsWithGoals.ContainsKey(secondTeam))
                {
                    teamsWithGoals.Add(secondTeam, 0);
                }
                teamsWithGoals[secondTeam] += result[1];
            }
            Console.WriteLine("League standings:");
            var teamsList = teamsWithScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            int counter = 1;
            foreach (var team in teamsList)
            {
                Console.WriteLine("{0}. {1} {2}", counter, team.Key, team.Value);
                counter++;
            }
            //for (int i = 0; i < teamsList.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {teamsList[i]}");
               
            //}
            Console.WriteLine("Top 3 scored goals:");
            var bestTeams = teamsWithGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var team in bestTeams.Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
           
            
        }

        private static string Reverse(string team)
        {
            char[] array = team.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sb.Append(array[i]);
            }
            return sb.ToString();
        }

        
    }
}
