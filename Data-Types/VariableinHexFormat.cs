using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool result = Convert.ToBoolean(str);
            if (result) {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
