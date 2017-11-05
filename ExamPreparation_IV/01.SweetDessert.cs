using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ivanchoCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());
            decimal oneSetOfSix = (2 * bananasPrice) + (4 * eggsPrice) + (decimal)(0.2 * (double)berriesPrice);
            int numberOfSets = 0;
            decimal totalPrice = 0;
            if (numberOfGuests % 6 == 0)
            {
                numberOfSets = numberOfGuests / 6;
            }
            else
            {
                numberOfSets = numberOfGuests / 6 + 1;
            }
            totalPrice = numberOfSets * oneSetOfSix;
            if (ivanchoCash >= totalPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalPrice);
            }
            else
            {
                decimal neededMoney = totalPrice - ivanchoCash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", neededMoney);
            }
        }
    }
}
