using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "triangle") {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleleArea(side, height);
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                RectangleArea(width, height);
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                CircleArea(radius);
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                SquareArea(side);
            }
        }

        static void SquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine("{0:F2}", area);
        }

        static void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:F2}", area);
        }

        static void TriangleleArea(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine("{0:F2}", area);
        }
        static void RectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
