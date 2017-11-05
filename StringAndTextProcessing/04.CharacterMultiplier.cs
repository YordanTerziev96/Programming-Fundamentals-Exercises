using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string str1 = input[0];
            string str2 = input[1];
            int totalSum = MultiplyStrings(str1, str2);
            Console.WriteLine(totalSum);

        }
        static int MultiplyStrings(string one, string two)
        {
            int sum = 0;
            if (one.Length <= two.Length)
            {
                for (int i = 0; i < one.Length; i++)
                {
                    sum += one[i] * two[i]; 
                }
                
                for (int j = one.Length; j < two.Length; j++)
                {
                    sum += two[j];
                }               
            }
            else
            {
                for (int i = 0; i < two.Length; i++)
                {
                    sum += one[i] * two[i];
                }
                
                for (int j = two.Length; j < one.Length; j++)
                {
                    sum += one[j];
                }
            }
            return sum;
        }
    }
}
