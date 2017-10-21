using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
           
            var numbers = new List<int>();
           int[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();


            for (int j = 0; j < input.Length; j++)
            {
                int currentNum = input[j];

                if (currentNum >= 0)
                {
                    numbers.Add(currentNum); 
                }
                else
                {
                    if (j == input.Length - 1)
                    {
                        break;
                    }
                    currentNum += input[j + 1];
                    if (currentNum >= 0)
                    {
                        numbers.Add(currentNum);
                    }
                    j++;
                }
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}