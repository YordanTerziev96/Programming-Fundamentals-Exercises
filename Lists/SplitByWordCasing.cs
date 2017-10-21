using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        //, ; : . ! ( ) " ' \ / [ ] 
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\\', '\'', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in list)
            {
                bool isLowerCase = true;
                bool isUpperCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isLowerCase = false;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        isUpperCase = false;
                    }
                    else
                    {
                        isLowerCase = false;
                        isUpperCase = false;
                    }
                }
                if (isLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if (isUpperCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
