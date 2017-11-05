using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            while (nums.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int capturedElement = 0;
                
                    if (index < 0)
                    {
                        capturedElement = nums[0];
                        nums[0] = nums[nums.Count - 1];
                    }
                    else if (index > nums.Count - 1)
                    {
                        capturedElement = nums[nums.Count - 1];
                        nums[nums.Count - 1] = nums[0];
                   }
                    else
                    {
                        capturedElement = nums[index];
                        nums.RemoveAt(index);
                    }
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= capturedElement)
                    {
                        nums[i] += capturedElement;
                    }
                    else
                    {
                        nums[i] -= capturedElement;
                    }
                }
                sum += capturedElement;
            }
            Console.WriteLine(sum);
        }
    }
}
