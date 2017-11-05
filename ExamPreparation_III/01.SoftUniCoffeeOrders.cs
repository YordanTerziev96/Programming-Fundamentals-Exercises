using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal totalPrice = 0;
            List<decimal> currPrice = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                int capsules = int.Parse(Console.ReadLine());
                price = ReadOrderAndCalculatePrice(pricePerCapsule, date, capsules);
                totalPrice += price;
                currPrice.Add(price);
            }
            for (int i = 0; i < currPrice.Count; i++)
            {

                Console.WriteLine("The price for the coffee is: ${0:F2}", currPrice[i]);
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
        static decimal ReadOrderAndCalculatePrice(decimal price, DateTime date, int capsulesCount)
        {
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal totalPrice = (daysInMonth * (decimal)price) * capsulesCount;
            return totalPrice;
        }
    }
}
