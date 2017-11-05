using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allFiles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }
            string filter = Console.ReadLine();
            var filterTokens = Regex.Split(filter, " in ");
            var filterExt = "." + filterTokens[0];
            var filterRoot = filterTokens[1] + "\\";

            Dictionary<string, decimal> fileSize = new Dictionary<string, decimal>();
            foreach (var f in allFiles)
            {
                var tokens = f.Split(';');
                var size = decimal.Parse(tokens[1]);
                var path = tokens[0];
                
                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var pieces = path.Split('\\');
                    var fileName = pieces[pieces.Length - 1];
                    fileSize[fileName] = size;
                }
            }

            var sortedOutputFile = fileSize.OrderByDescending(fs => fs.Value).ThenBy(fs => fs.Key);
         
                foreach (var file in sortedOutputFile)
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            if (sortedOutputFile.Count() == 0)
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
