using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    public class Circle
    {
       
        public int radious { get; set; }
        public Point center { get; set; }
    }
    public class Point
    {
       public int X { get; set; }
       public int Y { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle firstCircle = new Circle();
            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = input1[0];
            p1.Y = input1[1];
            firstCircle.radious = input1[2];
            firstCircle.center = p1;
            p2.X = input2[0];
            p2.Y = input2[1];

            Circle secondCircle = new Circle();
            secondCircle.radious = input2[2];
            secondCircle.center = p2;
            
            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            
            double distance = Math.Sqrt(Math.Pow(c1.center.X - c2.center.X, 2) + Math.Pow(c1.center.Y - c2.center.Y, 2));
            if (distance <= c1.radious + c2.radious)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
