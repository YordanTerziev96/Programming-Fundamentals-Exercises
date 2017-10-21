using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string method = Console.ReadLine().ToLower();
            Properties(side, method);

        }
        static void Properties(double side, string function)
        {
            double s = side * side;
            double face = 6 * s;
            double volume = s * side;
            double spaceDiagonal = Math.Sqrt(3*s);
            double faceDiagonal = Math.Sqrt(2*s);

            if (function == "area")
            {
                Console.WriteLine("{0:F2}", face);
            }
            else if (function == "space")
            {
                Console.WriteLine("{0:F2}", spaceDiagonal);
            }
            else if (function == "face")
            {
                Console.WriteLine("{0:F2}", faceDiagonal);
            }
            else if (function == "volume")
            {
                Console.WriteLine("{0:F2}", volume);
            }
        }

    }
}
