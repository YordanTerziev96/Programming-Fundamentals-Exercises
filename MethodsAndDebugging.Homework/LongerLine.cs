using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longerdistance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double distanceA = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double distanceB = GetDistanceBetweenTwoPoints(x3, y3, x4, y4);

            if (distanceA >= distanceB && IsCloserToZero(x1, y1, x2, y2))
            {
                Console.Write($"({x1}, {y1})({x2}, {y2})");
            }
            else if (distanceA >= distanceB && IsCloserToZero(x1, y1, x2, y2) == false)
            {
                Console.Write($"({x2}, {y2})({x1}, {y1})");
            }
            else if (distanceA <= distanceB && IsCloserToZero(x3, y3, x4, y4))
            {
                Console.Write($"({x3}, {y3})({x4}, {y4})");
            }
            else if (distanceA <= distanceB && IsCloserToZero(x3, y3, x4, y4) == false)
            {
                Console.Write($"({x4}, {y4})({x3}, {y3})");
            }


        }
        static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            
            double distance = Math.Sqrt((x2-x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
        static bool IsCloserToZero(double x1, double y1, double x2, double y2)
        {
            bool closer = false;
            double dist1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double dist2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (dist1 <= dist2) {
                closer = true;
            }
            return closer;
        }

    }
}
