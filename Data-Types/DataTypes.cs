using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double sh = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double Vis = double.Parse(Console.ReadLine());
            double V = (dul + sh + Vis) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);



        }
    }
}



